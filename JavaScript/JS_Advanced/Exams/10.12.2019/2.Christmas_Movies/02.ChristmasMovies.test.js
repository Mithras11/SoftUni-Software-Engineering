const ChristmasMovies = require('./02. Christmas Movies_Resources');
const { expect } = require('chai');

describe('ChristmasMovies', () => {

    let movies;
    beforeEach(function() {
        movies = new ChristmasMovies();
    });

    describe('class ChristmasMovies', () => {
        it('instantiates valid class', () => {
            expect(movies.movieCollection).to.eql([]);
            expect(movies.movieCollection.length).to.eql(0);
            expect(movies.watched).to.eql({});
            expect(movies.actors).to.eql([]);
            expect(movies.actors.length).to.eql(0);

        });
    });

    describe('buyMovie', () => {
        it('adds movie to collection', () => {
            expect(movies.buyMovie('Hell', ['He', 'She'])).to.equal(`You just got Hell to your collection in which He, She are taking part!`);
        });

        it('throws error when movie already in collection', () => {
            movies.buyMovie('Movie', ['He', 'She'])
            expect(function() { movies.buyMovie('Movie', ['He', 'She']) }).to.throw();
        });

        it('adds only unique actors', () => {
            expect(movies.buyMovie('Hell', ['He', 'She', 'She'])).to.equal(`You just got Hell to your collection in which He, She are taking part!`);
        });
    });


    describe('discardMovie', () => {
        it('throws error if movie is not in the collection', () => {
            expect(function() { movies.discardMovie('Pepi') }).to.throw();
        });

        it('throws error if movie has not been watched', () => {
            movies.buyMovie('Pepi', ['Nemo']);
            expect(function() { movies.discardMovie('Pepi') }).to.throw();
        });

        it('deletes movie that is already in the collection', () => {
            movies.buyMovie('BlahBlah', ['Nemo']);
            movies.watchMovie('BlahBlah');
            expect(movies.discardMovie('BlahBlah')).to.equal('You just threw away BlahBlah!')
        });


    });

    describe('watchMovie', () => {
        it('adds new movie to wathedList', () => {
            movies.buyMovie('Hello', ['Nemo']);
            movies.watchMovie('Hello');
            expect(movies.watched['Hello']).to.equal(1);
        });

        it('adds increases counter in wathedList', () => {
            movies.buyMovie('Hello', ['Nemo']);
            movies.watchMovie('Hello');
            movies.watchMovie('Hello');
            expect(movies.watched['Hello']).to.equal(2);
        });

        it('throws error if movie is not in the collection', () => {
            expect(function() { movies.watchMovie('Ab') }).to.throw(Error, 'No such movie in your collection!');
        })
    });

    describe('favouriteMovie', () => {
        it('throws error if there are no movies in the watchedList', () => {
            expect(function() { movies.favouriteMovie() }).to.throw();
        });

        it('returns message with favourite movie', () => {
            movies.buyMovie('Hello', ['Nemo']);
            movies.watchMovie('Hello');
            movies.watchMovie('Hello');
            movies.buyMovie('BlahBlah', ['Memo']);
            movies.watchMovie('BlahBlah');

            expect(movies.favouriteMovie()).to.equal('Your favourite movie is Hello and you have watched it 2 times!')
        });
    });

    describe('mostStarredActor', () => {
        it('throws error if there are no movies in the collection', () => {
            expect(function() { movies.mostStarredActor() }).to.throw();
        });

        it('returns message with most starred actor', () => {
            movies.buyMovie('Hello', ['Nemo']);
            movies.watchMovie('Hello');
            movies.watchMovie('Hello');
            movies.buyMovie('BlahBlah', ['Nemo']);
            movies.watchMovie('BlahBlah');
            movies.buyMovie('LaLa', ['Gummo']);
            movies.watchMovie('LaLa');

            expect(movies.mostStarredActor()).to.equal('The most starred actor is Nemo and starred in 2 movies!')
        })
    });

});