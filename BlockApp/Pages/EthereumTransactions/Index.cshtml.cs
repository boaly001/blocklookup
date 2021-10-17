using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlockApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockApp.Pages.EthereumTransactions
{
    public class IndexModel : PageModel
    {
        private readonly BlockApp.Data.EthereumDbContext _context;

        public IndexModel(BlockApp.Data.EthereumDbContext context)
        {
            _context = context;
        }

        public IList<EthereumTransaction> TransactionList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList SearchResults { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BlockHash { get; set; }
        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> blockHashQuery = from m in _context.EthereumTransaction
                                            orderby m.From
                                            select m.BlockHash;

            var transactions = from m in _context.EthereumTransaction
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                transactions = transactions.Where(s => s.BlockHash.Equals(SearchString));
            }

            if (!string.IsNullOrEmpty(BlockHash))
            {
                transactions = transactions.Where(x => x.BlockHash == BlockHash);
            }

            SearchResults = new SelectList(await blockHashQuery.Distinct().ToListAsync());

            TransactionList = await transactions.ToListAsync();
        }
    }
}