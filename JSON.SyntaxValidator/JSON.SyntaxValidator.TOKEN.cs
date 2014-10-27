/*
 JSON Syntax Validator
 (C) Torres Frederic 2013

 Based on code from: How do I write my own parser? (for JSON) By Patrick van Bergen http://techblog.procurios.nl/k/618/news/view/14605/14863/How-do-I-write-my-own-parser-for-JSON.html
 My library heavily change Patrick van Bergen's code. 
 
 The library is release under the Mit Style License

 */
using System;
using System.Collections;
using System.Globalization;
using System.Text;
using DynamicSugar;
using System.Collections.Generic;

namespace JSON.SyntaxValidator
{
    public enum TOKENS
    {
        NONE         ,
        ID           , 
        CURLY_OPEN   ,
        CURLY_CLOSE  ,
        SQUARED_OPEN ,
        SQUARED_CLOSE,
        COLON        ,
        COMA         ,
        STRING       ,
        NUMBER       ,
        TRUE         ,
        FALSE        ,
        NULL
    };
}

