namespace IssuesManagerAbstract
{
    /// <summary>
    /// Interfejs managera zarządzającego problemami (Issues) we wskazanym repozytorium 
    /// </summary>
    public interface IIssuesManager
    {
        /// <summary>
        /// Pobiera wszystkie problemy określonego repozytorium
        /// </summary>
        /// <param name="repositoryApiURL">Adres API repozytorium</param>
        /// <returns>Odpowiedź REST</returns>
        public Task<HttpResponseMessage> GetAllIssuesAsync(string repositoryApiURL);

        /// <summary>
        /// Dodaje problem do określonego repozytorium o przekazanym tytule i opisie
        /// </summary>
        /// <param name="repositoryApiURL">Adres API repozytorium</param>
        /// <param name="name">Tytuł problemu</param>
        /// <param name="description">Opis problemu</param>
        /// <returns>Odpowiedź REST</returns>
        public Task<HttpResponseMessage> AddIssueAsync(string repositoryApiURL, string name, string description);

        /// <summary>
        /// Modyfikuje tytuł i opis problemu o wskazanym numerze
        /// </summary>
        /// <param name="repositoryApiURL">Adres API repozytorium</param>
        /// <param name="name">Tytuł problemu</param>
        /// <param name="description">Opis problemu</param>
        /// <param name="issueNumber">Numer edytowanego problemu</param>
        /// <returns>Odpowiedź REST</returns>
        public Task<HttpResponseMessage> ModifyIssueAsync(string repositoryApiURL, string name, string description, int issueNumber);

        /// <summary>
        /// Zamyka problem o numerze wskazanym w parametrze
        /// </summary>
        /// <param name="repositoryApiURL">Adres API repozytorium</param>
        /// <param name="issueNumber">Numer problemu</param>
        /// <returns>Odpowiedź REST</returns>
        public Task<HttpResponseMessage> CloseIssueAsync(string repositoryApiURL, int issueNumber);
    }
}
