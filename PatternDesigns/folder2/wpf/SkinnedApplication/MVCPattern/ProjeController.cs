namespace SkinnedApplication.MVCPattern
{ 
    class ProjeController
    {
        private IProje projeModel; 
        private IProjeView  projeView;
 
        public ProjeController(IProje proje, IProjeView projeView) 
        {
            this.projeModel = proje;
            this.projeView = projeView; 
        }
 
        public void DisplayProjeInfo()
        {
            projeView.DisplayProjeView(this.projeModel);
        }
    }
}