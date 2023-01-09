namespace CollectionsExercises;

class WebpageHistory{
    // Create a stack to store the history of visited web pages
    Stack<string> webHistory;
    string currentPage;

    public WebpageHistory(){
        webHistory = new Stack<string>();
        currentPage = "";
    }

    public string CurrentPage { get => currentPage; set => currentPage = value; }

    public void GoBack(){
        this.webHistory.Pop();
        this.currentPage = this.webHistory.Peek();
    }

    public void VisitNewWebPage(string url){
        this.webHistory.Push(url);
        this.CurrentPage = this.webHistory.Peek();
    }
}