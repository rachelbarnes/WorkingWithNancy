using Nancy;

namespace ConfigsPrototype
{
    //i had nancy asp.host and nancy asp.self and i got routing problems... so just don't have both of those installed at the same time 
    public class ConfigsModule1 : NancyModule
    {
        //notes from NancyFx Tutorial (youtube)
        //doesn't impose mvc, rather works with modules
                //these modules expose the http verbs


        public ConfigsModule1()
        {
            Get["/"] = _ =>
            {
                return "<h1>Heller World!</h1><br/><br/><h3>This is my first time working with Nancy!!</h3><p style='color:orange'>She has lots of nice hard candy, as most elderly women do</p>";
            };
            Get["/Sample/{YourName?RachelBarnes}"] = req =>
            {
                //why can't i get the segments to work?  
                req.YourName = "Rachel Barnes";
                return "Hello Ms. " + req.YourName;
            }; 
        }
    }
}
