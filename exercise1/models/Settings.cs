namespace exercise1.models
{
    public class Settings
    {
        public string SubjectLine { get; set; }
        public string Title { get; set; }
        public string FromName { get; set; }
        public string ReplyTo { get; set; }
        public bool UseConversation { get; set; }
        public string ToName { get; set; }
        public string FolderId { get; set; }
        public bool Authenticate { get; set; }
        public bool AutoFooter { get; set; }
        public bool InlineCss { get; set; }
        public bool AutoTweet { get; set; }
        public bool FbComments { get; set; }
        public bool Timewarp { get; set; }
        public int TemplateId { get; set; }
        public bool DragAndDrop { get; set; }
    }
}