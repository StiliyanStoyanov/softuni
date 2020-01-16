const expect = require('chai').expect;
const SubscriptionCard = require("../SubscriptionCard");

describe('Subscription card tests', function () {

    describe('Constructor tests', function () {
        it('should be initialized correctly', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            expect(card.firstName).to.be.equal('Pesho')
            expect(card.lastName).to.be.equal('Petrov')
            expect(card.SSN).to.be.equal('00000000')
        });
    });

    describe('isBlocked', function () {
        it('should return false for new object', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            expect(card.isBlocked).to.be.equal(false)
        });
        it('should return true for blocked card', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.block()
            expect(card.isBlocked).to.be.equal(true)
        });
        it('should return false for blocked and unblocked card', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.block()
            card.unblock()
            expect(card.isBlocked).to.be.equal(false)
        });
        it('should return true for unblocked and blocked card', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.unblock()
            card.block()
            expect(card.isBlocked).to.be.equal(true)
        });
    });

    describe('addSubscription tests', function () {
        it('subscription should be undefined with empty arr', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            expect(card._subscriptions.length).to.be.equal(0);
            expect(card._subscriptions[0]).to.be.equal(undefined);
            expect(card._subscriptions).to.be.eql([]);
        });

        it('should add valid subscription', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions.length).to.be.equal(1);
            expect(card._subscriptions[0].line).to.be.equal('120');
            expect(card._subscriptions[0].startDate).to.be.eql(new Date('2018-04-22'));
            expect(card._subscriptions[0].endDate).to.be.eql(new Date('2018-05-21'));
        });

        it('should add 2 valid subscription', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            card.addSubscription('*', new Date('2018-05-25'), new Date('2018-06-24'));
            expect(card._subscriptions.length).to.be.equal(2);
            expect(card._subscriptions[0].line).to.be.equal('120');
            expect(card._subscriptions[0].startDate).to.be.eql(new Date('2018-04-22'));
            expect(card._subscriptions[0].endDate).to.be.eql(new Date('2018-05-21'));
            expect(card._subscriptions[1].line).to.be.equal('*');
            expect(card._subscriptions[1].startDate).to.be.eql(new Date('2018-05-25'));
            expect(card._subscriptions[1].endDate).to.be.eql(new Date('2018-06-24'));
        });
    });

    describe('isValid tests', function () {
        it('Empty card', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            expect(card.isValid('120', new Date('2018-04-22'))).to.be.equal(false);
        });

        it('One day before', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('120', new Date('2018-04-21'))).to.be.equal(false);
        });

        it('One day after', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('120', new Date('2018-05-22'))).to.be.equal(false);
        });

        it('On start date', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('120', new Date('2018-04-22'))).to.be.equal(true);
        });

        it('On end date', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('120', new Date('2018-05-21'))).to.be.equal(true);
        });

        it('On invalid line', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('121', new Date('2018-04-25'))).to.be.equal(false);
        });

        it('On * line with valid date', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('12523', new Date('2018-04-25'))).to.be.equal(true);
        });

        it('One day before with * lin', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('12523', new Date('2018-04-21'))).to.be.equal(false);
        });

        it('One day after with * line', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card.isValid('12523', new Date('2018-05-22'))).to.be.equal(false);
        });

        it('Blocked card with valid subscription', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
            card.block()
            expect(card.isValid('*', new Date('2018-04-25'))).to.be.equal(false);
        });
    });

    it('should not change', function () {
        const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
        card.firstName = 'test'
        card.lastName = 'test'
        card.SSN = 'test'
        expect(card.firstName).to.be.equal('Pesho');
        expect(card.lastName).to.be.equal('Petrov');
        expect(card.SSN).to.be.equal('00000000');
    });
});