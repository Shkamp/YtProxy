using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using VideoLibrary;

namespace ytproxy.Controllers
{
    public class YoutubeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string GetVideo(string id)
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            //var video = youTube.GetVideo("https://www.youtube.com/watch?v=" + id); // gets a Video object with info about the video
            var videos = youTube.GetAllVideos("https://www.youtube.com/watch?v=" + id);
            
            foreach (var video in videos)
            {

                if(video.Resolution == 360)
                return (video.Uri)
;            }
            
            return "novideo" ;
            //return videos[0].Uri;
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}