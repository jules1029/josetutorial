function CoffeGetterImperative() {
    this.selectedCoffeeId = 0;
    this.coffeePrice = 0;
    this.setCoffee = (coffeeName) => {
        //this business logic could get more complex
        switch(coffeeName) {
            case 'decaf': 
                this.selectedCoffeeId = 1;
                break;
            case 'mocha':
                this.selectedCoffeeId = 2;
                break;
            case 'chai':
                this.selectedCoffeeId = 3;
                break;
            default:
                this.selectedCoffeeId = 1;
                break;
        }
    }

    this.setCoffeePrice = () => {
        switch(this.selectedCoffeeId) {
            case 1: 
                this.coffeePrice = 1.40;
                break;
            case 2:
                this.selectedCoffeeId = 3.00;
                break;
        }
    }
}

let coffee = new CoffeGetterImperative();
coffee.setCoffee('decaf');
coffee.coffeePrice;
coffee.setCoffeePrice();
coffee.setCoffee('mocha');
coffee.coffeePrice;

function CoffeGetterFunctional() {
    this.getCoffeeId = (coffeeName) => {
        //this business logic could get more complex
        switch(coffeeName) {
            case 'decaf': 
                return { selectedCoffeeId: 1 };
            case 'mocha':
                return { selectedCoffeeId: 2 };
            case 'chai':
                return { selectedCoffeeId: 3 };
            default:
                return { selectedCoffeeId: 4 };
        }
    }

    this.getCoffeePrice = (coffeeId) => {
        switch(coffeeId) {
            case 1: 
                return 1.40;
            case 2:
                return 3.00;
        }
    }
}

let functional = new CoffeGetterFunctional();
let coffee = functional.getCoffeeId('decaf');
coffee = functional.getCoffeeId('mocha');


let price = functional.getCoffeePrice(coffee.coffeeId);

