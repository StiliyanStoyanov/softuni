let expect = require("chai").expect;
let createList = require("../createList").createList;


describe("createList Tests", function() {
    let list;
    beforeEach(function () {
        list = createList();
    });

    describe('check for empty array test', function () {
        it('should be an empty array', function () {
            expect(list.toString()).to.equal("");
        });
    });

    describe('add test', function () {
        it('should return [5, 6]', function () {
            list.add(5);
            list.add(6);
            expect(list.toString()).to.equal('5, 6');
        });
    });

    describe('shiftsLeft correctly', function () {
        it('should move the first element to last position', function () {
            list.add(2);
            list.add(3);
            list.add(5);
            list.shiftLeft();
            expect(list.toString()).to.equal('3, 5, 2');
        });
    });

    describe('shiftsRight correctly', function () {
        it('should move the last element to first position', function () {
            list.add(2);
            list.add(3);
            list.add(5);
            list.shiftRight();
            expect(list.toString()).to.equal('5, 2, 3');
        });
    });

    describe('swap is invalid ', function () {
        it('with negative indexes (should not swap)', function () {
            list.add(5);
            list.add(4);
            list.add(3);
            let negativeIndexes = list.swap(-1, -3);
            expect(negativeIndexes).to.equal(false);
            expect(list.toString()).to.equal('5, 4, 3');
        });
        it('with invalid index1 (should not swap)', function () {
            list.add(5);
            list.add(3);
            let invalidIndex1 = list.swap(5, 1);
            expect(invalidIndex1).to.equal(false);
            expect(list.toString()).to.equal('5, 3');
        });
        it('with invalid index2 (should not swap)', function () {
            list.add(5);
            list.add(3);
            let invalidIndex2 = list.swap(0, 5);
            expect(invalidIndex2).to.equal(false);
            expect(list.toString()).to.equal('5, 3');
        });
        it('with both possitive invalid indexes (should not swap)', function () {
            list.add(5);
            list.add(3);
            let possitiveInvalidIndexes = list.swap(4, 5);
            expect(possitiveInvalidIndexes).to.equal(false);
            expect(list.toString()).to.equal('5, 3');
        });
        it('equal indexes (should not swap)', function () {
            list.add(5);
            list.add(3);
            let possitiveInvalidIndexes = list.swap(1, 1);
            expect(possitiveInvalidIndexes).to.equal(false);
            expect(list.toString()).to.equal('5, 3');
        });
        it('with different element types (should not swap)', function () {
            list.add({gosho: "aaa"});
            list.add('bbb');
            list.add(6);
            let swap = list.swap(5, 2);
            expect(swap).to.be.equal(false);
            expect(list.toString()).to.be.equal('[object Object], bbb, 6')

        });
        it('with a non integer first index', function () {
            list.add(5);
            list.add(3);
            let possitiveInvalidIndexes = list.swap('aaa', 1);
            expect(possitiveInvalidIndexes).to.equal(false);
            expect(list.toString()).to.equal('5, 3');
        });
        it('with a non integer first index', function () {
            list.add(5);
            list.add(3);
            let possitiveInvalidIndexes = list.swap([2,5], 1);
            expect(possitiveInvalidIndexes).to.equal(false);
            expect(list.toString()).to.equal('5, 3');
        });
    });

    describe('swap is valid', function () {
        it('with valid index 1 and 2 (should swap)', function () {
            list.add(5);
            list.add(4);
            list.add(3);
            let swap = list.swap(0, 2);
            expect(swap).to.equal(true);
            expect(list.toString()).to.equal('3, 4, 5');
        });
        it('with valid but index 2 is smaller than index 1 (should still swap)', function () {
            list.add(5);
            list.add(3);
            let possitiveInvalidIndexes = list.swap(1, 0);
            expect(possitiveInvalidIndexes).to.equal(true);
            expect(list.toString()).to.equal('3, 5');
        });
        it('with different types elements', function () {
            list.add({gosho: "aaa"});
            list.add('bbb');
            list.add(6);
            let swap = list.swap(0, 2);
            expect(swap).to.be.equal(true);
            expect(list.toString()).to.be.equal('6, bbb, [object Object]')

        });
    });
});
