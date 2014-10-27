JSON.SyntaxValidator v 1.0
==========================

# What is it?

JSON.SyntaxValidator is a C# library to validate JSON strictly or in relax mode.

## Why this library? 
Because all .NET JSON frameworks I tested (in 01/2013) do not follow strictly the 
JSON standard and this is what you I needed to work with JSON.parse() in JavaScript.
Once the JSON is validated, you can also access the data programmatically.
JSON.SyntaxValidator is a read-only library.

By default the library strictly follows the [JSON](http://www.json.org) standard
- Property name must be string
- String use double quote only
- No trailing comma
- No // comment
- No /* */ Comment

The library is used in the Visual Studio extension [TextHighlighterExtension](http://visualstudiogallery.msdn.microsoft.com/6706b602-6f10-4fd1-8e14-75840f855569)
to validate JSON on the fly syntax validation.

##Samples:

JSON Sample:

    {
	    "LastName" : "Torres"			   ,
	    "FirstName": "Frederic"			   ,
	    "BirthDate": "1964-12-11T00:00:00Z",
	    "Age"	   : 48					   ,
	    "Male"	   : true				   ,
	    "Other"	   : null
    }

C# Sample:

    [TestMethod]
    public void ParseSimpleJsonFile()
    {
        var json = DS.Resources.GetTextResource("Me.json", Assembly.GetExecutingAssembly());

        var o    = (Hashtable) new JSON.SyntaxValidator.Compiler().Validate(json);

        Assert.AreEqual("Torres", o["LastName"]);
        Assert.AreEqual("Frederic", o["FirstName"]);
        Assert.AreEqual(new DateTime(1964,12,11), o["BirthDate"]);
        Assert.AreEqual(48.0, o["Age"]);
        Assert.AreEqual(true, o["Male"]);
        Assert.AreEqual(null, o["Other"]);
    }


## Relax Mode

To support
- /* */ Comment
- property name defined as ID or string
- Trailing comma
The relax mode can be activated in programmatically

Sample:

    var o = (Hashtable) new JSON.SyntaxValidator.Compiler().Validate(json, supportStartComment:true, relaxMode:true);


## License

The software is subject to the MIT license: you are free to use it in any way you like, but it must keep its license.