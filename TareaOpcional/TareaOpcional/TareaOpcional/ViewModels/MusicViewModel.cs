using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TareaOpc.Models;

namespace TareaOpc.ViewModels
{
     public class MusicViewModel
    {
        public ObservableCollection<Music> music { get; set; }

        public MusicViewModel()
        {
            music = new ObservableCollection<Music>
                {
                    new Music { MusicPicture = "Music01"},
                    new Music { MusicPicture = "Music02"},
                    new Music { MusicPicture = "Music03"},
                    new Music { MusicPicture = "Music04"},
                    new Music { MusicPicture = "Music05"}

                 };
        }
    }
}
    


