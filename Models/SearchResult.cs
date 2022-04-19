using System.Collections.Generic;

namespace WpfApp1.Models;

public class SearchResult
{
    public int page { get; set; }
    public List<Movie> results { get; set; }
    public int total_results { get; set; }
    public int total_pages { get; set; }
}