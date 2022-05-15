using PipesAndFiltersPattern.ConsoleApp.Concretions;
using PipesAndFiltersPattern.ConsoleApp.Interfaces;

IMessage priozitizedNotEncryptedMessage =
new Message(messageId: Guid.NewGuid().ToString(),
            body: "This is the message body",
            header: "Header Information",
            subject: "Please set priority and encrypt the message");

SendPipeline sendPipelineClientX = new(true, false);
var publishedMessageClientX = sendPipelineClientX.PerformOperation(priozitizedNotEncryptedMessage);
Console.WriteLine("I am client X and my messages should only be prioritized and not encrypted.");
Console.WriteLine($"Is the message prioritized? {publishedMessageClientX.IsMessagePrioritySet()}");
Console.WriteLine($"Is the message encrypted? {publishedMessageClientX.IsMessageEncrypted()}");
Console.WriteLine(new String('-', 40));

IMessage priozitizedAndEncryptedMessage =
new Message(messageId: Guid.NewGuid().ToString(),
            body: "This is the message body",
            header: "Header Information",
            subject: "Please set priority and encrypt the message");

SendPipeline sendPipelineClientY = new(true, true);
var publishedMessageClientY = sendPipelineClientY.PerformOperation(priozitizedAndEncryptedMessage);
Console.WriteLine("I am client Y and my messages should be prioritized and encrypted.");
Console.WriteLine($"Is the message prioritized? {publishedMessageClientY.IsMessagePrioritySet()}");
Console.WriteLine($"Is the message encrypted? {publishedMessageClientY.IsMessageEncrypted()}");

Console.Read();
