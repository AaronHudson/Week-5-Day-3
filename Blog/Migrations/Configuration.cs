namespace Blog.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.Models.Posts>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.Models.Posts context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.PostDB.AddOrUpdate(g => g.ID,
                new Post(DateTime.Now) { Title = "Curabitur et arcu", Body = "Curabitur et arcu eros. Phasellus viverra elementum nisl. Aenean a orci aliquet, tincidunt lectus at, mollis sapien. Quisque ac sagittis risus, quis scelerisque velit. Aenean consequat leo ac diam lobortis finibus. Nunc tempus neque efficitur, laoreet justo id, porttitor magna. Quisque tincidunt justo sit amet tortor suscipit varius. Nam ornare, nisl non posuere facilisis, justo libero molestie sem, nec elementum lectus lorem sed eros. Sed semper enim augue, eu pellentesque neque euismod vitae. Mauris a turpis dolor. Aenean tristique non urna eget tempus. Cras arcu nunc, mollis eget ornare convallis, semper sodales massa. " },
                new Post(DateTime.Now) { Title = "Fusce scelerisque metus", Body = "Fusce scelerisque metus non augue auctor elementum. Sed sed pulvinar urna. Vivamus laoreet erat ipsum. Pellentesque eleifend convallis pharetra. Sed fringilla velit id tempor sodales. Ut aliquam vel velit in venenatis. Quisque sit amet maximus elit, in blandit tellus." },
                new Post(DateTime.Now) { Title = "Nulla congue aliquet", Body = "Nulla congue aliquet urna, in ultrices nulla vulputate vel. Maecenas tempus ex ut placerat condimentum. In quis efficitur ex. Suspendisse potenti. Nunc velit lorem, fermentum id consequat eget, cursus sit amet velit. Etiam sed molestie ligula. Vivamus eleifend dui facilisis, finibus nisi ut, tempus tortor. In eget luctus lectus. Vestibulum lobortis vitae est auctor laoreet. Etiam feugiat elit velit, nec dictum tortor tristique quis. Vestibulum metus nisl, rhoncus in interdum vitae, aliquam et metus. Sed tristique venenatis lorem. Morbi dolor sapien, mollis ac leo sit amet, interdum dictum lectus. " },
                new Post(DateTime.Now) { Title = "Lorem ipsum dolor", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eget tincidunt augue. Morbi semper purus id sollicitudin consequat. Donec porta, lacus ac sodales facilisis, nunc sem ultrices lectus, id gravida augue massa sed orci. Phasellus vestibulum elementum consectetur. Aliquam ullamcorper laoreet bibendum. Integer suscipit sagittis sagittis. Nulla risus ante, suscipit at mi nec, ullamcorper gravida velit. Vivamus iaculis, purus ac tincidunt bibendum, tortor nisl mollis odio, ut accumsan felis neque ut nisl. Nulla eget libero bibendum diam blandit egestas. Maecenas vitae ex ut risus ultricies ullamcorper sit amet vel sem. Vestibulum lobortis, lectus vel semper eleifend, mauris odio convallis mi, id finibus sapien eros at arcu. Praesent dolor leo, fringilla viverra enim ac, elementum ultricies felis. Phasellus tortor nibh, venenatis ut bibendum consectetur, lacinia vitae nibh. Fusce pharetra egestas tempor. Integer ornare at lorem a interdum. " }
                );
        }
    }
}