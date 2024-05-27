﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarabaseSQLMusicApp
{
    internal class AlbumsDAO
    {
        string connectionString =
            "datasource=localhost;port=3306;username=root;password=root;database=music;";

        public List<Album> getAllAlbums()
        {
            List<Album> list = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS",connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    a.Tracks = getTracksForAlbum(a.ID);
                    list.Add(a);
                }
            }
            connection.Close();
            return list;
        }

        internal int addOneAlbum(Album album)
        {
            List<Album> list = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumtitle,@artist,@year,@imageURL,@description) ", connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            int res = command.ExecuteNonQuery();
            connection.Close();

            return res;
        }

        internal object searchTitles(string text)
        {

            List<Album> list = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string search = "%"+ text +"%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", search);
            command.Connection = connection;


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };

                    list.Add(a);
                }
            }
            connection.Close();
            return list;
        }

        public List<Track> getTracksForAlbum(int albumID)
        {

            List<Track> list = new List<Track>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                    };

                    list.Add(t);
                }
            }
            connection.Close();
            return list;
        }

        public List<JObject> getTracksUsingJoin(int albumID)
        {

            List<JObject> list = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT tracks.ID as trackID,albums.ALBUM_TITLE,`track_title`, `video_url`,`lyrics` FROM `tracks` JOIN albums ON albums_ID=albums.ID where albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    JObject newTrack = new JObject();

                    for (int i=0;i<reader.FieldCount;i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    };

                    list.Add(newTrack);
                }
            }
            connection.Close();
            return list;
        }

        internal int deleteTrack(object trackID)
        {
            List<Album> list = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM `tracks` WHERE `tracks`.`ID` = @trackID ", connection);

            command.Parameters.AddWithValue("@trackID", trackID);

            int res = command.ExecuteNonQuery();
            connection.Close();

            return res;
        }
    }

}
