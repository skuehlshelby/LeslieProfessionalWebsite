namespace LeslieProfessionalWebsite
{
    public class Publication
    {
        public Publication(string url, string title, string authors, DateOnly datePublished, string journal, string @abstract, bool isOpenAccess, string downloadLink)
        {
            Title=title;
            Authors=authors;
            DatePublished=datePublished;
            Journal=journal;
            Abstract=@abstract;
            URL=url;
            IsOpenAccess=isOpenAccess;
            DownloadLink=downloadLink;
        }

        public string URL { get; }

        public string Title { get; }

        public string Authors { get; }

        public DateOnly DatePublished { get; }

        public string Journal { get; }

        public string Abstract { get; }

        public bool IsOpenAccess { get; }

        public string DownloadLink { get; }
    }
}
