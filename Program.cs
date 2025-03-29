double  valorTotal, pagamentoM, taxasMensais, valorNPago, iofD;

Console.Clear();
Console.WriteLine("--- Crédito Rotativo do Cartão de Crédito ---");

Console.WriteLine("");

Console.WriteLine("Valor total da fatura (R$)...:");
valorTotal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pagamento mínimo (%).........:");
pagamentoM = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Taxa de juros mensais (%)....:");
taxasMensais = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

pagamentoM = (pagamentoM/100) * valorTotal;

Console.WriteLine($"Pagamento mínimo..................:R$ {pagamentoM}");

Console.WriteLine("");

Console.WriteLine("--- Caso Seja Pago o Valor Mínimo ---");

Console.WriteLine("");

valorNPago = valorTotal - pagamentoM;

iofD = (0.0082/100 * valorNPago) * 30;

Console.WriteLine($"Valor não pago....................:R$ {valorNPago}");
Console.WriteLine($"Juros.............................:R$ {(taxasMensais/100) * valorNPago}");
Console.WriteLine($"IOF mensal........................:R$ {(0.38/100) * valorNPago}");
Console.WriteLine($"IOF diário........................:R$ {iofD:N2}");

Console.WriteLine("");

Console.WriteLine($"Valor a pagar na próxima fatura...:R$ {valorNPago + iofD + ((0.38/100) * valorNPago) + ((taxasMensais/100) * valorNPago):N2}");
Console.WriteLine($"Custo do crédito rotativo.........:R$ {iofD + ((0.38/100) * valorNPago) + ((taxasMensais/100) * valorNPago):N2}");