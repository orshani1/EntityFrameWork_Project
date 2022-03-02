using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss.AccountModel;


namespace DigitalATM.DB.Modelss.CreditCardModel
{
    public class CardsRepository : GenericRepository<CreditCard>, ICardRepository
    {
        public CardsRepository(DigitalATMContext context) : base(context)
        {

        }


        public string CreateAndReturnCreditCard(Account account)
        {
            var cardDetails = string.Empty;
            using (var db = new DigitalATMContext())
            {
                Random random = new Random();

                var cardnumber = GenerateRandomCreditNumber();
                var cardCVV = random.Next(100, 999);
                var cards = db.CreditCards.Select(c => c.CardNumber).ToList();
                foreach (var number in cards)
                {
                    if (number == cardnumber)
                    {
                        cardnumber = GenerateRandomCreditNumber();

                    }
                }
                var holder = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c.FirstName + " " + c.LastName).ToString();
                CreditCard card = new CreditCard()
                {
                    AccountId = account.AccountId,
                    CardCvv = cardCVV,
                    CardExpiredDate = DateTime.Today.Date.AddYears(2),
                    CardHolder = holder,
                    CardNumber = cardnumber
                };
                db.CreditCards.Add(card);
                db.SaveChanges();
                cardDetails = $"Card Created\nCard Number: {cardnumber}\nCard Cvv{cardCVV}";
            }
            return cardDetails;
        }

        public void CreateNewCreditCard(Account account)
        {
            throw new NotImplementedException();
        }

        public void DeleteCreditCard(int creditCardNumber)
        {
            using (var db = new DigitalATMContext())
            {
                var card = db.CreditCards.Where(c => c.CardNumber == creditCardNumber).
                    Select(c => c).FirstOrDefault();
                db.Remove(card);
                db.SaveChanges();
            }
        }

        public List<int> GetCards()
        {
            using (var db = new DigitalATMContext())
            {
                var cards = db.CreditCards.Select(c => c.CardId).ToList();
                return cards;
            }
        }

        public CreditCard GetThisCard(Account Account)
        {
            using (var db = new DigitalATMContext())
            {
                var card = db.CreditCards.Where(c => c.AccountId == Account.AccountId).
                    Select(c => c).FirstOrDefault();
                return card;
            }
        }

        public CreditCard GetThisCard(int CardId)
        {
            using (var db = new DigitalATMContext())
            {
                var credit = db.CreditCards.Where(c => c.CardId == CardId).
                    Select(c => c).FirstOrDefault();
                return credit;
            }
        }

        public int GetThisUserCardsCount(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var clientCount = db.CreditCards.Where(c => c.AccountId == account.AccountId).
                    Select(c => c).Count();
                return clientCount;
            }
        }
        public static string GenerateRandomBankNumber()
        {
            string bankNumber = string.Empty;
            for (int i = 0; i <= 8; i++)
            {
                var rand = new Random();
                bankNumber += rand.Next(0, 10).ToString();

            }
            return bankNumber;
        }
        public static int GenerateRandomCreditNumber()
        {
            var random = new Random();


            var cardNumber = string.Empty;
            var cardNumberArray = new int[6];
            foreach (var item in cardNumberArray)
            {
                cardNumber += random.Next(0, 10);
            }

            return int.Parse(cardNumber);

        }
    }
}
