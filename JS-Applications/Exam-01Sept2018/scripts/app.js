$(() => {
    const app = Sammy('#container', function () {
        this.get('index.html', getWelcomePage);
        this.get('#/home', getWelcomePage);
        this.get('#/register', function (ctx) {
            ctx.loadPartials({
                footer: './templates/common/footer.hbs',
                navigation: './templates/common/navigation'
            }).then(function () {
                this.partial('./templates/forms/register.hbs');
            });
        });
        this.get('#/login', function (ctx) {
            ctx.loadPartials({
                footer: './templates/common/footer.hbs',
                navigation: './templates/common/navigation'
            }).then(function () {
                this.partial('./templates/login.hbs');
            });
        });



        function getWelcomePage(ctx) {
            ctx.loadPartials({
                footer: './templates/common/footer.hbs',
                navigation: './templates/common/navigation.hbs'
            }).then(function () {
                this.partial('./templates/welcome.hbs');
            });
        }
    });

    app.run();
});