class Card
    {
        private char back = '*';
        private int front;
        private bool side; //if false card is face down, if true card is face up

        public Card()
        {
            this.front = 1;
            this.side = false;
        }

        public Card(int n)
        {
            this.front = n;
            this.side = false;
        }

        public Card(Card card)
        {
            this.front = card.front;
            this.side = card.side;
        }
        //accessors
        public void SetFront(int n)
        {
            this.front = n;
        }

        public void SetFaceDown()
        {
            this.side = false;
        }

        public void SetFaceUp()
        {
            this.side = true;
        }

        //mutators
        public int GetFront()
        {
            return this.front;
        }

        public char GetBack()
        {
            return this.back;
        }

        public bool GetSide()
        {
            return this.side;
        }

        //methods
        public void FlipCard()
        {
            if (this.side)
            {
                this.SetFaceDown();
            }
            else
            {
                this.SetFaceUp();
            }
        }
    }
