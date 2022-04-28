namespace Client
 {
    public class Proje : IProje
    {
        string _lesson;
        string _project;
        string _time;
        public string Lesson 
        {
            get { return _lesson; }
            set { _lesson = value; }
        }
        public string project
        {
            get { return _project; }
            set { _project = value; }
        }
        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}