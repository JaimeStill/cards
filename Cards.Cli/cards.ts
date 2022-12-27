export enum SuitValue {
    Spade,
    Heart,
    Club,
    Diamond
}

export class Card {
    private readonly _value: number;
    private readonly _suit: SuitValue | null;

    constructor(value: number, suit: SuitValue | null = null) {
        this._value = value;
        this._suit = suit;
    }

    get suit(): string {
        switch (this._suit) {
            case (SuitValue.Spade):
                return "Spades";
            case (SuitValue.Heart):
                return "Hearts";
            case (SuitValue.Club):
                return "Clubs";
            case (SuitValue.Diamond):
                return "Diamonds";
            default:
                return '';
        }
    }
    
    get value(): string {
        switch(this._value) {
            case (1):
                return "Ace"
            case (11):
                return "Jack"
            case (12):
                return "Queen"
            case (13):
                return "King"
            case (14):
                return "Small Joker"
            case (15):
                return "Big Joker"
            default:
                return this._value.toString();
        }
    }

    toString = (): string => this.suit
        ? `${this.value} of ${this.suit}`
        : this.value;

    static Deck = (jokers: boolean = false): Card[] => {
        const deck = new Array<Card>();

        for (let i = 0; i < 4; i++)
            for (let j = 1; j < 14; j++)
                deck.push(new Card(j, <SuitValue>i));

        if (jokers)
            deck.push(
                new Card(14),
                new Card(15)
            );

        return deck;
    }

    shuffle = (cards: Card[]) => {
        const n: number = cards.length;
        
        for (let i = 0; i < n - 1; i++) {
            const r: number = Math.floor(Math.random() * n - i);
            [cards[i], cards[r]] = [cards[r], cards[i]];            
        }
    }
}





