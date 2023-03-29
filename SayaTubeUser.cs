using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210124.modul6_1302210124
{
    internal class SayaTubeUser
    {
        private int id;
        List <SayaTubeVideo> uploadedVideos;
        string username;
        
        public SayaTubeUser(string nama) {
            this.username = nama;
            Debug.Assert(username.Length <= 100 && username != null, "maksimal nama 100 karakter dan tidak null.");
            
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotaVideoPlayCount() {
            int totaVideoPlayCount = 0;
            foreach(SayaTubeVideo video in uploadedVideos)
            {
                totaVideoPlayCount += video.getPlayCount();
            }
            return totaVideoPlayCount;
        }

        public void addVideo(SayaTubeVideo video) { 
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount() {
            int i = 0;
            Console.WriteLine("User: " + username);
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                Console.WriteLine("Video " + i + " judul: " + uploadedVideos[i].getTitle());
                i++;
            }
        }
    }
}
