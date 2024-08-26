namespace Latoken.Api.Client.Library.Constants
{
    public static class ApiPath
    {
        private static string s_restVersion2 = "v2";

        // BookController
        public static string GetOrderBook(string baseCurrency, string quoteCurrency, int limit) => $"/{s_restVersion2}/book/{baseCurrency}/{quoteCurrency}?limit={limit}";

        // PairController
        public static string GetPairs = $"/{s_restVersion2}/pair";

        public static string GetAvailablePairs = $"/{s_restVersion2}/pair/available";
        public static string GetFeeSchemeForPair(string baseCurrency, string quoteCurrency) => $"/{s_restVersion2}/trade/fee/{baseCurrency}/{quoteCurrency}";

        // CurrencyController 
        public static string GetCurrency(string currency) => $"/{s_restVersion2}/currency/{currency}";
        public static string GetCurrencies = $"/{s_restVersion2}/currency";

        // TickerController
        public static string GetTickers = $"/{s_restVersion2}/ticker";
        public static string GetTicker(string baseCurrency, string quoteCurrency) => $"/{s_restVersion2}/ticker/{baseCurrency}/{quoteCurrency}";
        public static string GetRate(string baseCurrency, string quoteCurrency) => $"/{s_restVersion2}/rate/{baseCurrency}/{quoteCurrency}";

        // TradeController Public
        public static string GetAllTrades(string baseCurrency, string quoteCurrency, int size) =>
            $"{s_restVersion2}/trade/history/{baseCurrency}/{quoteCurrency}?limit={size}";

        public static string GetChartData(string baseCurrency, string quoteCurrency, string resolution, long from, long to) =>
            $"{s_restVersion2}/tradingview/history?symbol={baseCurrency}%2F{quoteCurrency}&resolution={resolution}&from={from}&to={to}";

        // TradeController Auth
        public static string GetClientTrades(long from, int size) => $"/{s_restVersion2}/auth/trade?from={from}&limit={size}";
        public static string GetClientTradesPair(string baseCurrency, string quoteCurrency, long from, int size) =>
            $"/{s_restVersion2}/auth/trade/pair/{baseCurrency}/{quoteCurrency}?from={from}&limit={size}";

        // OrderController Auth
        public static string GetOrdersFrom(long from, int size) => $"/{s_restVersion2}/auth/order?from={from}&limit={size}";
        public static string GetOrders(int size) => $"/{s_restVersion2}/auth/order?limit={size}";
        public static string GetAllOrdersPair(string baseCurrency, string quoteCurrency, int page, int size) =>
            $"{s_restVersion2}/auth/order/pair/{baseCurrency}/{quoteCurrency}";
        public static string GetActiveOrdersPair(string baseCurrency, string quoteCurrency, int page, int size) =>
            $"{s_restVersion2}/auth/order/pair/{baseCurrency}/{quoteCurrency}/active?size={size}&page={page}";

        public static string PlaceOrder = $"{s_restVersion2}/auth/order/place";
        public static string CancelOrder = $"{s_restVersion2}/auth/order/cancel";
        public static string GetOrder(string orderId) => $"/{s_restVersion2}/auth/order/getOrder/{orderId}";
        public static string TransferByUserId = $"/{s_restVersion2}/auth/transfer/id";
        public static string SpotWithdraw = "/v2/auth/transfer/spot/withdraw";
        public static string SpotDeposit = "/v2/auth/spot/deposit";
        public static string CancelAllOrders(string baseCurrency, string quoteCurrency) => $"{s_restVersion2}/auth/order/cancelAll/{baseCurrency}/{quoteCurrency}";

        // AccountController Auth
        public static string GetBalances(bool zeros) => $"/{s_restVersion2}/auth/account?zeros={zeros}";
        public static string GetAllTransfers(int page = 0) => $"/{s_restVersion2}/auth/transfer?page={page}";
        public static string GetUser => $"/{s_restVersion2}/auth/user";
        public static string GetBalancesByType(string currency, string typeOfAccount) => $"/{s_restVersion2}/auth/account/currency/{currency}/{typeOfAccount}";


        //WS endpoints
        public static string s_latokenWSURL = "wss://api.latoken.com/stomp";
        private static string s_wsVersion = "v1";
        public static char s_stompSeparator = '/';

        //balances
        public static string LAWSAccount(string accountId, out string id)
        {
            id = LAHeaders.ACCOUNT_ID;
            return $"/user/{accountId}/{s_wsVersion}/account";
        }

        //orders
        public static string LAWSOrders(string accountId, out string id)
        {
            id = LAHeaders.ORDER_ID;
            return $"/user/{accountId}/{s_wsVersion}/order";
        }

        //trades
        public static string LAWSMyTrades(string accountId, string baseId, string quoteId, out string id)
        {
            id = $"{LAHeaders.MY_TRADES_ID}{s_stompSeparator}{baseId}{s_stompSeparator}{quoteId}";
            return $"/user/{accountId}/{s_wsVersion}/trade/{baseId}/{quoteId}";
        }

        //orer book
        public static string LAWSOrderBook(string baseId, string quoteId, out string id)
        {
            id = $"{LAHeaders.ORDER_BOOK_ID}{s_stompSeparator}{baseId}{s_stompSeparator}{quoteId}";
            return $"/{s_wsVersion}/book/{baseId}/{quoteId}";
        }

        //Trading competitions
        public static string GetActiveTradingCompetitionsApiPath(int page = 0, int size = 10) => $"/{s_restVersion2}/tradingcompetition/active?page={page}&size={size}";

        public static string GetActiveAirdropsApiPath(int page = 0, int size = 10) => $"/{s_restVersion2}/airdrop/bot/activeReferralAirdrops";

        public static string GetTradingCompetitionApiPath(string competitionId) => $"/{s_restVersion2}/tradingcompetition/{competitionId}";
        
        public static string GetAllTradingCompetitionsApiPath(int page = 0, int size = 10) => $"/{s_restVersion2}/tradingcompetition/all?page={page}&size={size}";

        public static string GetUserPsotionForTradingCompetitionApiPath(string competitionId) => $"/{s_restVersion2}/auth/tradingcompetition/competitor/{competitionId}";

        public static string GetTradingCompetitionLeaderBoardApiPath(string competitionId, int page, int size) => $"/{s_restVersion2}/auth/tradingcompetition/competitors/{competitionId}?page={page}&size={size}";
    }
}
