function createCard(face, suit) {

    const validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'K', 'Q', 'A'];

    const suitToString = {
        'S': '\u2660',
        'H': '\u2665',
        'D': '\u2666',
        'C': '\u2663',
    };

    if (!validFaces.includes(face)) {
        throw new Error('Invalid face');

    } else if (!Object.keys(suitToString).includes(suit)) {
        throw new Error('Invalid suit');
    }

    return {
        face,
        suit,
        toString() {
            return `${face}${suitToString[suit]}`;
        }
    }

}

createCard('A', 'S');