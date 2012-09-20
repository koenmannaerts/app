using System.Linq;
using Machine.Specifications;
using app.utility.container;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
  [Subject(typeof(FetchDependencies))]
  public class FetchDepencies
  {
    public abstract class concern : Observes<IFetchDependencies>
    {

    }

    public class when_fething_dependencies : concern
    {
      Establish c = () =>
      {
        depends.on<SomeDependency>(instance_of_SomeDependency);
        
      };
      Because b = () =>
        result = sut.an<SomeDependency>();

      It should_return_an_implementation_of_the_depency = () =>
        result.ShouldEqual(instance_of_SomeDependency);

      static SomeDependency result;
      static IFetchDependencies the_container_facade;
      static SomeDependency instance_of_SomeDependency;
    }
  }

  public class SomeDependency
  {
  }
}
