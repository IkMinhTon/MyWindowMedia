using MMDPlayer.GUI;
using MMDPlayer.Object;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MMDPlayer
{
    public class Utils
    {
        public static List<Media> listMedia = new List<Media>();
        public static string DEF_DIRECTORY = Directory.GetCurrentDirectory() + "\\Data\\";
        public static string DEF_LIST_LOCATION = Directory.GetCurrentDirectory() + "\\Data\\def-name.list";
        public static string DEF_PLAYLIST_LOC = Directory.GetCurrentDirectory() + "\\Data\\def-loc.list";
        public static string DEF_HISTORY_LOC = Directory.GetCurrentDirectory() + "\\Data\\def-history.list";
        public static bool InProcess = false;
        public static int WriteToJsonFile(string filePath, List<SongView> list, bool saveToListMedia = true, bool append = false)
        {
            TextWriter writer = null;
            try
            {
                if (!InProcess)
                {
                    if (list != null && list.Count > 0)
                    {
                        if (!Directory.Exists(DEF_DIRECTORY)) Directory.CreateDirectory(DEF_DIRECTORY);
                        DirectoryInfo directory = new DirectoryInfo(DEF_DIRECTORY);
                        InProcess = true;
                        string contentsToWriteToFile = "";
                        if (saveToListMedia)
                        {
                            foreach (SongView song in list)
                            {
                                if (!listMedia.Contains(song.mediaInfo))
                                {
                                    listMedia.Add(song.mediaInfo);
                                }
                            }
                            contentsToWriteToFile = JsonConvert.SerializeObject(listMedia);
                        } else
                        {
                            List<Media> historyList = new List<Media>();
                            foreach (SongView song in list)
                            {
                                if (!historyList.Contains(song.mediaInfo))
                                {
                                    historyList.Add(song.mediaInfo);
                                }
                            }
                            contentsToWriteToFile = JsonConvert.SerializeObject(historyList);
                        }
                        var encoding = Encoding.UTF8.GetBytes(contentsToWriteToFile);
                        writer = new StreamWriter(filePath, append);
                        writer.Write(Convert.ToBase64String(encoding));
                    } else
                    {
                        FileInfo file = new FileInfo(filePath);
                        if (file.Exists) file.Delete();
                    }
                    InProcess = false;
                    return 1;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error at: " + e.ToString());
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return 0;
        }

        public static int WriteLibraryPlayList(string filePath, List<PlayList> list, bool append = false)
        {
            TextWriter writer = null;
            try
            {
                if (list != null && list.Count > 0)
                {
                    if (!Directory.Exists(DEF_DIRECTORY)) Directory.CreateDirectory(DEF_DIRECTORY);
                    var contentsToWriteToFile = JsonConvert.SerializeObject(list);
                    var encoding = Encoding.UTF8.GetBytes(contentsToWriteToFile);
                    writer = new StreamWriter(filePath, append);
                    writer.Write(Convert.ToBase64String(encoding));
                }
                else
                {
                    FileInfo file = new FileInfo(filePath);
                    if (file.Exists) file.Delete();
                }
                    return 1;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error at: " + e.ToString());
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return 0;
        }

        public static List<PlayList> ReadLibraryPlayList(string filePath)
        {
            TextReader reader = null;
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (file != null && file.Exists)
                {
                    reader = new StreamReader(filePath);
                    var fileContents = reader.ReadToEnd();
                    var decoding = Convert.FromBase64String(fileContents);
                    fileContents = Encoding.UTF8.GetString(decoding);
                    var list = JsonConvert.DeserializeObject<List<PlayList>>(fileContents);
                    if (list != null && list.Count > 0)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            PlayList playList = list[i];
                            FileInfo fileLoc = new FileInfo(playList.Path);
                            if (!fileLoc.Exists) list.Remove(playList);
                        }
                    } else
                    {
                        FileInfo fileDef = new FileInfo(DEF_PLAYLIST_LOC);
                        if (fileDef.Exists) fileDef.Delete();
                    }
                    return list;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error at: " + e.ToString());
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return null;
        }
        public static List<Media> ReadFromJsonFile(string filePath)
        {
            TextReader reader = null;
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (file != null && file.Exists)
                {
                    reader = new StreamReader(filePath);
                    var fileContents = reader.ReadToEnd();
                    var decoding = Convert.FromBase64String(fileContents);
                    fileContents = Encoding.UTF8.GetString(decoding);
                    var listMedia = JsonConvert.DeserializeObject<List<Media>>(fileContents);
                    Utils.listMedia = listMedia;
                    return listMedia;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error at: " + e.ToString());
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return null;
        }

        public static List<SongView> ChangeMediaInfoToView(string loc)
        {
            List<SongView> listView = new List<SongView>();
            if (loc.Length <= 0) loc = DEF_LIST_LOCATION; 
            List<Media> listMedia = ReadFromJsonFile(loc);
            if (listMedia != null && listMedia.Count > 0)
            {
                foreach (var mediaInfo in listMedia)
                {
                    if (mediaInfo != null)
                    {
                        FileInfo file = new FileInfo(mediaInfo.Path);
                        if (file.Exists)
                        {
                            listView.Add(new SongView(mediaInfo));
                        }
                    }
                }
            }
            return listView;
        }

        public static TimeSpan GetTotalTime(List<SongView> list)
        {
            int hours = 0, minutes = 0, seconds = 0;
            if (list != null && list.Count > 0)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    var mediaInfo = list[i];
                    hours += mediaInfo.mediaInfo.Time.Hours;
                    minutes += mediaInfo.mediaInfo.Time.Minutes;
                    seconds += mediaInfo.mediaInfo.Time.Seconds;
                }
            }
            return new TimeSpan(hours, minutes, seconds);
        }
    }
}
