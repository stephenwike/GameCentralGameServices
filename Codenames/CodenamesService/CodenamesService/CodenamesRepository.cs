namespace CodenamesService
{
    internal sealed class CodenamesRepository
    {
        private static CardCollection mOriginalCards;
        private static CardCollection mDeepUndercoverCards;
        private static CardCollection mPicturesCards;

        public static CardCollection OriginalCards
        {
            get
            {
                if (mOriginalCards == null)
                {
                    mOriginalCards = CardData.GenerateOriginal();
                }
                return mOriginalCards;
            }
        }
        public static CardCollection DeepUnderCoverCards
        {
            get
            {
                if (mDeepUndercoverCards == null)
                {
                    mDeepUndercoverCards = CardData.GenerateDeepUnderCover();
                }
                return mDeepUndercoverCards;
            }
        }
        public static CardCollection PicturesCards
        {
            get
            {
                if (mPicturesCards == null)
                {
                    mPicturesCards = CardData.GenerateOriginal(); // TODO: Get Picture Cards
                }
                return mPicturesCards;
            }
        }
    }
}