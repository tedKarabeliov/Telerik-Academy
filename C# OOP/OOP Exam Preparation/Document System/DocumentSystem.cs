using System;
using System.Collections.Generic;
using System.Linq;

public class DocumentSystem
{
    private static IList<Document> documents = new List<Document>();

    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }

    private static void AddTextDocument(string[] attributes)
    {
        TextDocument textDocument = new TextDocument();
        foreach (var att in attributes)
        {
            string[] currentProperty = att.Split('=');
            textDocument.LoadProperty(currentProperty[0], currentProperty[1]);
        }

        if (textDocument.Name != null)
        {
            documents.Add(textDocument);
            Console.WriteLine("Document added: " + textDocument.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddPdfDocument(string[] attributes)
    {
        PDF pdfDocument = new PDF();
        foreach (var att in attributes)
        {
            string[] currentProperty = att.Split('=');
            pdfDocument.LoadProperty(currentProperty[0], currentProperty[1]);
        }

        if (pdfDocument.Name != null)
        {
            documents.Add(pdfDocument);
            Console.WriteLine("Document added: " + pdfDocument.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddWordDocument(string[] attributes)
    {
        Word wordDocument = new Word();
        foreach (var att in attributes)
        {
            string[] currentProperty = att.Split('=');
            wordDocument.LoadProperty(currentProperty[0], currentProperty[1]);
        }

        if (wordDocument.Name != null)
        {
            documents.Add(wordDocument);
            Console.WriteLine("Document added: " + wordDocument.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddExcelDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddAudioDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddVideoDocument(string[] attributes)
    {
        // TODO
    }

    private static void ListDocuments()
    {
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }

    private static void EncryptDocument(string name)
    {
        bool hasFound = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name && doc is IEncryptable)
            {
                if (doc is IEncryptable)
                {
                    (doc as IEncryptable).Encrypt();
                    Console.WriteLine("Document encrypted: " + doc.Name);
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: " + doc.Name);
                }
                hasFound = true;
            }
        }
        if (!hasFound)
        {
            Console.WriteLine("Document not found: " + name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool hasFound = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name && doc is IEncryptable)
            {
                if (doc is IEncryptable)
                {
                    (doc as IEncryptable).Decrypt();
                    Console.WriteLine("Document decrypted: " + doc.Name);
                }
                else
                {
                    Console.WriteLine("Document does not support decryption: " + doc.Name);
                }
                hasFound = true;
            }
        }
        if (!hasFound)
        {
            Console.WriteLine("Document not found: " + name);
        }
    }

    private static void EncryptAllDocuments()
    {
        bool hasFound = false;

        foreach (var doc in documents)
        {
            if (doc is IEncryptable)
            {
                (doc as IEncryptable).Encrypt();
                hasFound = true;
            }
            if (hasFound)
            {
                Console.WriteLine("All documents encrypted");
            }
            else
            {
                Console.WriteLine("No encryptable documents found");
            }
        }
    }

    private static void ChangeContent(string name, string content)
    {
        bool hasFound = false;

        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                if (doc is IEditable)
                {
                    (doc as IEditable).ChangeContent(content);
                    Console.WriteLine("Document content changed: " + doc.Name);
                }
                else
                {
                    Console.WriteLine("Document is not editable: " + doc.Name);
                }
                hasFound = true;
            }
        }
        if (!hasFound)
        {
            Console.WriteLine("Document not found: " + name);
        }
            
    }
}
