﻿using HW12Library;
NewsProvider newsProvider = new NewsProvider();
Client client1 = new Client();
Client client2 = new Client();
Client client3 = new Client();
client1.SubscribeNews(newsProvider);
client1.SubscribeWeather(newsProvider);
client1.SubscribeSports(newsProvider);
client2.SubscribeNews(newsProvider);
client2.SubscribeSports(newsProvider);
client2.SubscribeAccidents(newsProvider);
client3.SubscribeWeather(newsProvider);
client3.SubscribeAccidents(newsProvider);
client3.SubscribeHumor(newsProvider);
newsProvider.AddNews("Новые новости");
newsProvider.AddWeather("Новая погода");
newsProvider.AddSports("Новые новости спорта");
newsProvider.AddAccidents("Новые происшествия");
newsProvider.AddHumor("Искрометные шутки");
