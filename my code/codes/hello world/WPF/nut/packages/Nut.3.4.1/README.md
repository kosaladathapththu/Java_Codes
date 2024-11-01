# NUT - Number To Text

---

Number To Text Converter

Money To Text Converter

**Supported Languages:** English, French, Russian, Spanish, Turkish, Ukrainian, Bulgarian, Amharic, Polish, Belarussian, Portuguese.

**Supported Currencies:** EUR, USD, RUB, TRY, UAH, BGN, ETB, PLN, BYN, ARS, BRL.

**Number Limit:** 1 trillion

---

**USAGE - Number To Text**

```csharp

    var number = 123456
    var text = number.ToText("en");

    var number = 123456;
    var text = number.ToText(Language.English);
```

---

**USAGE - Money To Text**

```csharp

    var number = 123456.78
    var moneyText = number.ToText("usd", "en");

    var number = 123456.78;
    var moneyText = number.ToText(Nut.Currency.USD, Nut.Language.English);

    var number = 123456.78;
    var options = new Nut.Options {
        MainUnitNotConvertedToText = true,
        SubUnitNotConvertedToText = true,
        SubUnitZeroNotDisplayed = true,
        MainUnitFirstCharUpper = true,
        SubUnitFirstCharUpper = true,
        CurrencyFirstCharUpper = true
    }
    var moneyText = number.ToText(Nut.Currency.USD, Nut.Language.English, options);
```

---

**NUGET**

<https://www.nuget.org/packages/Nut/>

---

**THANKS**

- [Latif Turk](https://github.com/Latif07) - Ukrainian Language and Currency
- [SecreT2k8](https://github.com/SecreT2k8) - Bulgarian Language and Currency
- [ashGHub](https://github.com/ashGHub) - .Net Standart Migration, Ethiopian Language and Currency
- [kashiash](https://github.com/kashiash) - Polish Language and Currency
- [DeNcHiK3713](https://github.com/DeNcHiK3713) - Belarussian Language and Currency
- [Marciel032](https://github.com/Marciel032) - Portuguese Language and Currency
- [ArkadiuszMakosa](https://github.com/ArkadiuszMakosa) - Polish Language Unit Tests
- [Maryam1986](https://github.com/Maryam1986) - German Language and Currency

---

**LICENCE**

NUT-number-to-text is [MIT licensed.](LICENSE)

---
