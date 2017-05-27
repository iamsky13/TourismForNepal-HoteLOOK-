<!DOCTYPE html>
<html>
<head>
	<title>HoteLook - Look Before You Book</title>
</head>
<body>
<style>
      /* NOTE: The styles were added inline because Prefixfree needs access to your styles and they must be inlined if they are on local disk! */
      @import url(http://fonts.googleapis.com/css?family=Open+Sans);
#circle-shape-example { 
  font-family: Open Sans, sans-serif; 
  margin: 2rem; 
}
#circle-shape-example p { 
  line-height: 1.8; 
}
#circle-shape-example .curve { 
  width: 33%; height: auto;
  min-width: 150px;
  float: left;
  margin-right:2rem; 
  border-radius: 50%;
  -webkit-shape-outside:circle();
  shape-outside:circle();
}




    </style>
   
  </head>

  <body>

    <div id="circle-shape-example">
  <img src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/4273/kiwifruit-on-a-plate.jpg" alt="A photograph of sliced kiwifruit on a while plate" class="curve"><h1>KiwiFruit</h1>

  <p>This is kiwifruit: originally called “yang tao”, “melonette” or Chinese gooseberry. Cultivated in its fuzzy variety from Chinese imports, the fruit proved popular with American military servicemen stationed in New Zealand during World War II, with commercial export to the United States starting after the end of the war. In California, the fruit was rebranded as “kiwifruit” due to its resemblance to New Zealand’s national bird. However, it is not a “kiwi”, which is also the demonym for native New Zealanders. Saying “I’m going to eat a kiwi” implies that you are either a cannibal or planning to dine on an endangered flightless bird.</p>
</div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
<script src='http://demosthenes.info/assets/scripts/extras/shapes.js'></script>
</body>
</html>