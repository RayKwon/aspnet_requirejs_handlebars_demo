require(['jquery', 'underscore', 'backbone', 'hbs!../handlebars/app', './user_view'],
    function ($, _, Backbone, appTemplate, UserView) {
        
        var UserModel = Backbone.Model.extend({});

        var AppView = Backbone.View.extend({
            initialize: function () {
                this.render();
                this.renderSubView();                
            },
            template: appTemplate,
            id: 'app',            
            render: function () {                
                this.$el.html(this.template());
                $('body').html(this.el);
                return this;
            },
            renderSubView: function(){
                var userModel = new UserModel({ name: 'hyojung' });
                var userView = new UserView({ el: '#person', model: userModel });
                this.$el.append(userView.el);
            }
        });

        var appView = new AppView;
});

