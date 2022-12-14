namespace Algorithms
{
    
    public class SortingByChoiceClass
    {
        private MusicList musicList = new MusicList();
        
        public void ViewAllMusic()
        {
            var lst = musicList.ListMethod();
            foreach (var music in MusicList)
            {
                Console.WriteLine(music);
            }
        }
    }

    public class MusicList
    {
        private string? Music {get; set; }
        private int Listening {get; set; }

        public IList<MusicList> ListMethod()
        { 
            List<MusicList> musicians = new List<MusicList>();
            {
                musicians.Add(new MusicList{Music = "Black Mirror", Listening = 167});
                musicians.Add(new MusicList{Music = "Fire", Listening = 87});
                musicians.Add(new MusicList{Music = "Broken Glass", Listening = 97});
                musicians.Add(new MusicList{Music = "House of Mice", Listening = 15});
                musicians.Add(new MusicList{Music = "Ball", Listening = 354});
                musicians.Add(new MusicList{Music = "Carolina", Listening = 97});
                musicians.Add(new MusicList{Music = "Chamomile", Listening = 570});
                musicians.Add(new MusicList{Music = "Water Girl", Listening = 62});
                musicians.Add(new MusicList{Music = "CD Project Red", Listening = 34});
                musicians.Add(new MusicList{Music = "CJ", Listening = 16});
                musicians.Add(new MusicList{Music = "Killjoy", Listening = 74});
                musicians.Add(new MusicList{Music = "U", Listening = 41});
            }
            
            return musicians;
        }
    }

    /*class AppOptions
    {
        private MusicList musicList = new MusicList();

        public void viewAllMusic()
        {
            var lst = musicList.listMethod();
        }
    }*/
}