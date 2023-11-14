using Latoken.Api.Client.Library.Commands;
using Latoken.Api.Client.Library.Constants;
using Latoken.Api.Client.Library.Dto.Rest;
using Latoken.Api.Client.Library.LA.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Latoken.Api.Client.Library
{
    /// <summary>
    ///     This interface used to work with REST connection
    /// </summary>
    public interface ILARestClient
    {
        Task<OrderBook> GetOrderBook(string baseCurrency, string quoteCurrency, int limit);
        Task<List<Pair>> GetPairs();
        Task<List<Pair>> GetAvailablePairs();
        Task<FeeScheme> GetFeeSchemeForPair(string baseCurrency, string quoteCurrency);
        Task<Currency> GetCurrency(string currency);
        Task<List<Currency>> GetCurrencies();
        Task<List<Ticker>> GetTickers();
        Task<Ticker> GetTicker(string baseCurrency, string quoteCurrency);
        Task<Rate> GetRate(string baseCurrency, string quoteCurrency);
        Task<List<Trade>> GetAllTrades(string baseCurrency, string quoteCurrency, int size = 100);
        
        Task<OHLCChartData> GetChartData(string baseCurrency, string quoteCurrency, string resolution, long from, long to);
        Task<List<Trade>> GetClientTrades(int page, int size);

        /// <summary>
        /// Gets the clients trades for the given base currency quote currency pair.
        /// </summary>
        /// <param name="baseCurrency">The base currency symbol ID or tag (Tag or ID)</param>
        /// <param name="quoteCurrency">The base currency symbol ID or tag (Tag or ID)</param>
        /// <param name="from">Request trade history for given timestamp from and before (by default it is current timestamp). In milliseconds
        /// Gets the timestamp from which the trades have to be fetched in reverse timeline.</param>
        /// <param name="size">The number of trades to fetch from the given from timestamp.
        /// Use ToUnixTimeMilliseconds() function to get this long value.</param>
        /// <returns>List of trades.</returns>
        Task<List<Trade>> GetClientTradesPair(string baseCurrency, string quoteCurrency, long from = 0, int size = 20);
        Task<List<Order>> GetOrders(int size);
        Task<List<Order>> GetOrdersFrom(long from = 0, int size = 1000);
        Task<List<Order>> GetAllOrdersForPair(string baseCurrency, string quoteCurrency, int page, int size);
        Task<List<Order>> GetActiveOrdersForPair(string baseCurrency, string quoteCurrency, int page = 0, int size = 20);
        Task<OrderResponse> PlaceOrder(OrderCommand command);
        Task<OrderResponse> CancelOrder(OrderIdCommand command);
        Task<Order> GetOrder(OrderIdCommand command);
        Task<List<Balance>> GetBalances(bool zeros = true);
        Task<CancelAllOrdersResponce> CancelAllOrders(string baseCurrency, string quoteCurrency);
        Task<LatokenUser> GetUser();
        Task<Balance> GetBalanceByType(string currencyId, TypeOfAccount typeOfAccount);

        /// <summary>
        /// Transfer from Spot to Wallet for the current user;
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Task.</returns>
        Task<Transaction> SpotWithdraw(SpotTransferCommand command);

        /// <summary>
        /// Transfer from Wallet to Spot for the current user;
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Task.</returns>
        Task<Transaction> SpotDeposit(SpotTransferCommand command);

        /// <summary>
        /// Transfer assets from the wallet of one user account to another.
        /// </summary>
        /// <param name="command">The parameter that specifies the transfer parameters.</param>
        /// <returns>Task.</returns>
        Task<Transaction> TransferInternal(TransferCommand command);

        /// <summary>
        ///     Returns true if the REST client is ready to establish a connection
        /// </summary>        

        Task<TradingCompetitions> GetTradingCompetitions(int page = 0);

        Task<TradingCompetitionUserPosition> GetUserPositionForTradingCompetition(string competitionId);

        bool IsReady();

        Task<TradingCompetitionLeaderBoardPositions> GetTradingCompetitionLeaderBoardPosition(string competitionId, int page, int size);
    }
}
