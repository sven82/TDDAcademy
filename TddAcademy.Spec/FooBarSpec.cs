namespace TddAcademy.Spec
{
    using FluentAssertions;
    using Xbehave;

    public class FooBarSpec
    {
        private Foo foo;

        [Background]
        public void Background()
        {
            this.foo = new Foo(new Bar());
        }

        [Scenario]
        public void Say()
        {
            string actual = null;

            "When foo says something"
                ._(() => actual = this.foo.Say());

            "Then foo should say 'foobar'"
                ._(() => actual.Should().Be("foobar"));
        }
    }
}