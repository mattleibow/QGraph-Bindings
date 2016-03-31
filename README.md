# QGraph

This binding is simple to create.

For Android, I added the .aar file to the poject and manipulated the namespace to be more .NET friendly:

https://github.com/mattleibow/QGraph-Bindings/blob/master/QGraph.Android/Transforms/Metadata.xml

    <attr path="/api/package[@name='com.quantumgraph.sdk']" name="managedName">QuantumGraph</attr>

For iOS, I ran the header through sharpie and added the generated file to the project:

https://github.com/mattleibow/QGraph-Bindings/blob/master/QGraph.iOS/ApiDefinition.cs

And, I added the .a file to the project along with linker directives:

https://github.com/mattleibow/QGraph-Bindings/blob/master/QGraph.iOS/libQGSdk.linkwith.cs
