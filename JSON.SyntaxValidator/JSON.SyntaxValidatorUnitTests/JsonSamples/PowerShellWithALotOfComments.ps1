﻿{
    "Caption"       : "{{name}}", <# Template defining the caption of the object #>
    "IDProperty"    : "name",     <# The property to use as the identifier       #>
                                  <# The sections and the properties order. The character @ define section, the character # define an action to use as a button #>
    "DisplayOrder"  : "name,Quantity,Unit,@Order,QuantityRequested,OrderID,OrderDate,DeviceID,#Order,@Product Information,Description,WebSite",
    "Sort"          : "name",     <# The property to use to sort the objects                            #>
    "GroupBy"       : null,       <# The property to use to group the object into sections               #>
    "NewProperties" : [           <# Properties to add the first time or each time the object is opened #>
                                {
                                    "Name"          : "QuantityRequested",
                                    "Value"         : 0,
                                    "AutoReset"     : true <# Re initialize the value each time the dialog is opened #>
                                },
                                {
                                    "Name"          : "DeviceName",
                                    "Value"         : "$DeviceName" <# $DeviceName macro        #>
                                },
                                {
                                    "Name"          : "DeviceID",
                                    "Value"         : "$DeviceID"   <# $DeviceID macro          #>
                                },
                                {
                                    "Name"          : "OrderDate",
                                    "Value"         : "$Now",       <# $Now macro               #>
                                    "AutoReset"     : true
                                },
                                {
                                    "Name"          : "OrderID",
                                    "Value"         : "$Guid",      <# $Guid macro              #>
                                    "AutoReset"     : true
                                },
                                {
                                    "Name"          : "WebSite",    <# Link to a website page   #>
                                    "Value"         : "http://www.freebase.com/view/en/{{name.lower()}}"
                                }
    ],
    "Actions"       : [
                                {
                                    "Name"          : "Order",      <# Name of the action                       #>
                                    "Type"          : "Button",     <# Button, ActionSheet(Default)             #>
                                    "Method"        : "Post",       <# Http (Post, Get, Delete, Put) or EMail   #>
                                    "Url"           : "http://fredericaltorres.jsonbdemos.jit.su/vegetables/update",
                                    "Parameters"    : "name={{name}}&QuantityRequested={{QuantityRequested}}&DeviceName={{DeviceName}}&DeviceID={{DeviceID}}&OrderID={{OrderID}}&OrderDate={{OrderDate}}",
                                    "ContentType"   : "application/x-www-form-urlencoded",
                                    "AutoPop"       : true,         <# Pop up back to the parent after the action is completed      #>
                                    "AutoReload"    : "Data",       <# Reload after the action is completed: Data, MetaData, All.   #>
                                    "Success"       : "{{QuantityRequested}} {{name}} ordered", <# Message to display after the action is completed successfully  #>
                                    "Failure"       : "Order failed"<# Message to display after the action failed                   #>
                                }
    ],
    "Properties"    : [     <# More info about the properties of the object #>
                                { "Name" : "name",              "Attr":"READONLY",  "Caption":"Name"                     },
                                { "Name" : "Quantity",          "Attr":"READONLY"                                        },
                                { "Name" : "QuantityRequested", "Attr":"EDITABLE",  "Range":[0, 100]                     },
                                { "Name" : "OrderDate",         "Attr":"DATE",      "Format":"MM/DD/YYYY HH:mm:SS"       },
                                { "Name" : "WebSite",           "Attr":"HTML",      "Caption":"WebSite about {{name}}"   }
    ]
}