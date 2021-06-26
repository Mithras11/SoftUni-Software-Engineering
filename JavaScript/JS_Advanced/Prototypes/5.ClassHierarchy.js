function solve() {

    class Figure {
        constructor(units = 'cm') {
            this.units = units;

        }

        changeUnits(newUnits) {
            this.units = newUnits;

        }

        toString() {
            return `Figures units: ${this.units}`;
        }


        _convertInput(value) {
            if (this.units === 'm') {
                return value /= 100;
            }
            if (this.units === 'mm') {
                return value *= 10;
            }


            return value;
        }

    }


    class Circle extends Figure {
        constructor(radius, units) {
            super(units);
            this._radius = radius;
        }

        get area() {
            return Math.PI * this.radius ** 2;
        }

        get radius() {
            return this._convertInput(this._radius);
        }

        toString() {
            return super.toString() + ` Area: ${this.area} - radius: ${this.radius}`
        }
    }


    class Rectangle extends Figure {
        constructor(width, height, units) {
            super(units);
            this._width = width;
            this._height = height;
        }

        get area() {
            return this.width * this.height;
        }

        get width() {
            return this._convertInput(this._width);
        }

        get height() {
            return this._convertInput(this._height);
        }

        toString() {
            return super.toString() + ` Area: ${this.area} - width: ${this.width}, height: ${this.height}`;
        }
    }


    return {
        Figure,
        Circle,
        Rectangle
    }
}