using System;

namespace CodenamesService
{
    internal sealed class CodenamesRepository
    {
        private static Lazy<CardCollection> mOriginalCards;
        private static Lazy<CardCollection> mNSFWCards;
        private static Lazy<CardCollection> mPicturesCards;

        public static CardCollection OriginalCards
        {
            get
            {
                if (mOriginalCards == null)
                {
                    mOriginalCards = new Lazy<CardCollection>(() => Utility.ReadJsonFile("OriginalCards.json"));
                }
                return mOriginalCards.Value;
            }
        }
        public static CardCollection NSFWCards
        {
            get
            {
                return mNSFWCards.Value;
            }
        }
        public static CardCollection PicturesCards
        {
            get
            {
                return mPicturesCards.Value;
            }
        }
    }
}