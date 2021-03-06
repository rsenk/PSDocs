﻿namespace PSDocs.Models
{
    public static class ModelHelper
    {
        public static Document NewDocument()
        {
            return new Document
            {

            };
        }

        public static Section NewSection(string name, int level)
        {
            return new Section
            {
                Content = name,
                Level = level
            };
        }

        public static Table NewTable()
        {
            return new Table
            {

            };
        }

        public static Code NewCode()
        {
            return new Code
            {

            };
        }

        public static Note NewNote()
        {
            return new Note
            {

            };
        }

        public static Warning NewWarning()
        {
            return new Warning
            {

            };
        }
    }
}
