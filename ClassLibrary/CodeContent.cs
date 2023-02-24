namespace ClassLibrary
{
    public class CodeContent
    {
        private string content = "";
        
        
        public void ChangeContent(string content)
        {
            this.content = content;
        }
        public string getRawContent()
        {
            return this.content;
        }
        public string getDisplayContent()
        {
            return "";
        }




    }
}
