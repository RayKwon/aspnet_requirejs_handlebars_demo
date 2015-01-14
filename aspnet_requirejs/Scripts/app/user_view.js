define(['backbone', 'hbs!../handlebars/user'], function (Backbone, userTemplate) {
    var UserView = Backbone.View.extend({
        initialize: function(){
            this.model.bind('change', this.render, this);
            this.render();
        },
        template: userTemplate,
        events: {
            'click .hello': 'onHelloClick'
        },
        render: function () {
            var html = this.template(this.model.toJSON());
            this.$el.html(html);
            return this;
        },
        onHelloClick: function () {
            console.log('hello');
        }
    });

    return UserView;
});