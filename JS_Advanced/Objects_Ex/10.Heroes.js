function solve() {

    return obj = {
        mage: function (name) {

            let newMage = {

                name,
                health: 100,
                mana: 100,

                cast: function (spell) {
                    this.mana--
                    console.log(`${this.name} cast ${spell}`);
                }
            }

            return newMage;
        },

        fighter: function (name) {

            let newFighter = {

                name,
                health: 100,
                stamina: 100,

                fight: function () {
                    this.stamina--;
                    console.log(`${this.name} slashes at the foe!`);
                }
            }

            return newFighter;
        }
    }

}

let create = solve();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball")
scorcher.cast("thunder")
scorcher.cast("light")

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight()

console.log(scorcher2.stamina);
console.log(scorcher.mana);