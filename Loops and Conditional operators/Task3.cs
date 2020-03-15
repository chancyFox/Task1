//первый способ - самый удобный и очевидный, потому что не возникает лишней иттерации:

            for (int i = 7; i < 100; i += 7)
            {
                Console.WriteLine(i);
            }
            
//второй способ - из-за того, что сначала выполняется проверка условия, а потом тело цикла, в котором происходит увеличение i,
//возникает лишняя иттерация, которой можно избежать с помощью 
//if-break или if-continue, но у меня почему-то получилось только так:

            int i = 0;
            while ((i+7) < 100)
            {
                i += 7;
                Console.WriteLine(i);
            }