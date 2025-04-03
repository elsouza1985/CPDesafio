📄 Explanation – Task 1: PoC for Personal Information Recognition
This solution is part of a Proof of Concept (PoC) to recognize personal information such as emails, phone numbers, and names using the Azure AI Language Service.

A resource named lang-49969938 was provisioned in the North Europe region with the Free (F0) pricing tier.
The implementation was done in C# using the official Azure.AI.TextAnalytics SDK.

✅ Main Steps:
Created an instance of TextAnalyticsClient using the Azure endpoint and key;

Sent a sample text to the RecognizePiiEntities() method;

Retrieved and printed:

Detected PII entities (Email, Phone, Person)

Redacted version of the input text

🧪 Sample Output:
yaml
Copiar
Editar
Redacted Text: Call our office at ************ and ask for Graham Barnes, or send an email to ***************.
Recognized:
→ Text: 312-555-1234, Category: PhoneNumber, Confidence: 80%
→ Text: support@contoso.com, Category: Email, Confidence: 80%
→ Text: Graham Barnes, Category: Person, Confidence: 100%
🛠️ Notes:
All requirements of the PoC have been met using the default PII model.

The implementation can be extended or reused for other input formats or dynamic sources.

