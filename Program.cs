﻿using System;
using System.IO;
using System.Net.Sockets;
using clojure.lang;
using clojure.clr.api;

RT.LoadSpecCode();

var load = Clojure.var("clojure.core", "load");
load.invoke("/src/clojure/cnrepl/debug");
load.invoke("/src/clojure/cnrepl/misc");
load.invoke("/src/clojure/cnrepl/bencode");
load.invoke("/src/clojure/cnrepl/sync_channel");
load.invoke("/src/clojure/cnrepl/version");
load.invoke("/src/clojure/cnrepl/transport");
load.invoke("/src/clojure/cnrepl/core");
load.invoke("/src/clojure/cnrepl/config");
load.invoke("/src/clojure/cnrepl/ack");
load.invoke("/src/clojure/cnrepl/util/completion");
load.invoke("/src/clojure/cnrepl/util/lookup");
load.invoke("/src/clojure/cnrepl/util/print");
load.invoke("/src/clojure/cnrepl/middleware");
load.invoke("/src/clojure/cnrepl/middleware/completion");
load.invoke("/src/clojure/cnrepl/middleware/print");
load.invoke("/src/clojure/cnrepl/middleware/caught");
load.invoke("/src/clojure/cnrepl/middleware/interruptible_eval");
load.invoke("/src/clojure/cnrepl/middleware/load_file");
load.invoke("/src/clojure/cnrepl/middleware/lookup");
load.invoke("/src/clojure/cnrepl/middleware/session");
load.invoke("/src/clojure/cnrepl/middleware/sideloader");
load.invoke("/src/clojure/cnrepl/middleware/dynamic_loader");
load.invoke("/src/clojure/cnrepl/helpers");
load.invoke("/src/clojure/cnrepl/server");
load.invoke("/src/clojure/cnrepl/cmdline");
var run = Clojure.var("cnrepl.cmdline", "-main");
run.invoke("-p","1667");
