let expect = require("chai").expect;
let Calculator = require("../testCode");

describe('Calculator tests', function () {
    describe('Methods Tests', function () {
        it('should return correct values', function () {
            let output = new Calculator();
            output.add(10);
            output.add("Pesho");
            output.add("5");
            expect(output.toString()).to.be.equal('10 -> Pesho -> 5');
        });

        it('should divide only the valid numbers', function () {
            let output = new Calculator();
            output.add(10);
            output.add("Pesho");
            output.add(10);
            expect(output.divideNums()).to.equal(1);
        });

        it('should sort correctly', function () {
            let output = new Calculator();
            output.add(10);
            output.add("Pesho");
            output.add(10);
            output.orderBy();
            expect(output.expenses).to.eql([10, 10, 'Pesho']);
        });

        it('should sort correctly string value', function () {
            let output = new Calculator();
            output.add(10);
            output.add("Pesho");
            output.add(10);
            expect(output.orderBy()).to.be.equal('10, 10, Pesho');
        });

        it('should have different data types', function () {
            let output = new Calculator();
            output.add({a: 'b'});
            output.add("Pesho");
            output.add(10);
            output.add([1]);
            expect(output.expenses).to.eql([{a: 'b'}, "Pesho", 10, [1]]);
        });

        it('should return empty', function () {
            let output = new Calculator();
            expect(output.orderBy()).to.equal('empty')
        });

        it('should return ordered mixed data', function () {
            let output = new Calculator();
            output.add({a: 'b'});
            output.add("Pesho");
            output.add(10);
            output.add([1]);
            output.add(new Map());
            output.orderBy();
            expect(output.toString()).to.be.equal('1 -> 10 -> Pesho -> [object Map] -> [object Object]');
        });

        it('should return cannot be divided by 0', function () {
            let output = new Calculator();
            output.add(10);
            output.add("Pesho");
            output.add(0);
            expect(output.divideNums()).to.be.equal('Cannot divide by zero')
        });

        it('should divide correctly', function () {
            let output = new Calculator();
            output.add(-2);
            output.add("Pesho");
            output.add(-15);
            output.add(5)
            expect(output.divideNums()).to.be.equal(0.026666666666666665)
            expect(output.toString()).to.be.equal('0.026666666666666665')
        });

        it('should divide correctly', function () {
            let output = new Calculator();
            output.add(-2.5);
            output.add("Pesho");
            output.add(-15);
            output.add(5.54)
            expect(output.divideNums()).to.be.equal(0.030084235860409144)
            expect(output.toString()).to.be.equal('0.030084235860409144')
        });

        it("throw an error", function(){
            let output = new Calculator();
            output.add("Pesho");
            expect(function(){
                output.divideNums();
            }).to.throw('There are no numbers in the array!');
        });
    });
});

