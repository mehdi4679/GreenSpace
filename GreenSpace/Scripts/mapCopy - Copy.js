// استایل محله ها 	
var areaStyle = new ol.style.Style({
    stroke: new ol.style.Stroke({
        color: '#ffffff',
        width: 0
    }),
    image: new ol.style.Circle({
        fill: new ol.style.Fill({
            color: 'blue'
        }),
        stroke: new ol.style.Stroke({
            color: '#ffcc00'
        }),
        radius: 8
    })
});

var styleCache = {};

function styleFunction(feature, resolution) {
    var cc = feature.get('Color');
    var id = feature.get('id');
    if (!styleCache[id]) {
        styleCache[id] = new ol.style.Style({
            image: new ol.style.Circle({
                 
                fill: new ol.style.Fill({
                    color: '#ffcc00'
                }),
                stroke: new ol.style.Stroke({
                    color: '#ffcc00'
                }),
                radius: 800
            })
        });
    }
    return [styleCache[id]];
}



/*
* Elements that make up the popup.
*/
var container = document.getElementById('popup');
var content = document.getElementById('popup-content');
var closer = document.getElementById('popup-closer');


/**
 * Create an overlay to anchor the popup to the map.
 */
var overlay = new ol.Overlay(/** @type {olx.OverlayOptions} */({
    element: container,
    autoPan: true,
    autoPanAnimation: {
        duration: 250
    }
}));

/**
  * Add a click handler to hide the popup.
  * @return {boolean} Don't follow the href.
  */
closer.onclick = function () {
    overlay.setPosition(undefined);
    closer.blur();
    return false;
};



// مشخص کردن پراجکشن نقشه
var projection = new ol.proj.Projection({
    code: 'EPSG:32639',
    units: 'm'
});


var popup2 = new ol.Overlay({
    element: document.getElementById('popup2')
});

////////http://192.168.200.25:6080/arcgis/rest/services/treebon/MapServer

// دریافت نقشه از لایه های مپ سرور	
//var layers = [
//    new ol.layer.Image({
//        extent: [462465, 3820270, 514830, 3848007],
//        source: new ol.source.ImageWMS({
//            url: 'http://localhost:8070/cgi-bin/mapserv.exe?map=C:/ms4w/apps/ms101/htdocs/wms.map',
//            params: {
//                'LAYERS': 'line1,line2,line3,line4,line5,line6,poly1',
//                'CRS': 'EPSG:32639',
//                'BBOX': '462465,3820270,514830,3848007',
//                'WIDTH': '800',
//                'HEIGHT': '500',
//                'FORMAT': 'image/png'
//            },
//            serverType: 'mapserver'
//        })
//    })
//];

//var layers = [
//new ol.layer.Tile({
//    source: new ol.source.OSM()
//})
//];

//ایجاد ویو و نقطه مرکزی نقشه
var view = new ol.View({
    center: [5666773.619324013,4116122.153228274],
    zoom: 12,
    projection: projection
});

var map = new ol.Map({
    target: 'map',
    overlays: [overlay, popup2],
    layers: [
    new ol.layer.Tile({
        source: new ol.source.OSM()
    })
    ],
    view: view
});






//ایجاد ویو و نقطه مرکزی نقشه
//var view = new ol.View({
//    center: [489152, 3833514],
//    zoom: 16,
//    projection: projection
//});


// ساخت نقشه
//var map = new ol.Map({
//    layers: layers,
//    target: 'map',
//    controls: ol.control.defaults({
//        zoom: true,
//        attribution: true,
//        rotate: true
//    })
//});

//map.setView(view);


//افزودن لایه برای نمایش تگ بر روی نقشه
map.addOverlay(popup2);





////افزودن قابلیت تعیین منطقه ای موس روی آن است///////////////////
//var mousePosition = new ol.control.MousePosition({
//    coordinateFormat: ol.coordinate.createStringXY(2),
//    projection: 'EPSG:32639',
//    target: document.getElementById('myposition'),
//    undefinedHTML: '&nbsp;'
//});
//map.addControl(mousePosition);
//////////////////////////////////////////////////////////////////
///// افزودن اکسل بار در پایین نقشه
//var sss = new ol.control.ScaleLine({
//    units: 'degrees',
//    minWidth: 100
//});
//map.addControl(sss);



var container = document.getElementById('popup2');
var bCordinate;


//////////////////////////////////////////////////////////
//برای کلیک بر روی نقشه و دریافت طول و عرض جغرافیایی باید ابتدا قابلیت کلیک را تعریف کنید
map.on('click', function (evt) {
    var coordinate = evt.coordinate; // دریافت نطقه کلیک شدخ
    bCordinate = evt.coordinate;

    /// با این بخش میتونید اطلاعات لایه هایی که تو اون نقطه هست را بیرون بیاری
    var region;
    var area;
    var sector;
    var features = [];

    //این حلقه تمام لایه های زیر را بدست میاره
    //map.forEachFeatureAtPixel(evt.pixel, function (feature, layer) {
    //    features.push(feature);
    //});

    //region = features[0].get('Region');  //منطقه
    //area = features[0].get('Area');      // ناحیه
    //sector = features[0].get('Sector');  // محله

    console.log('coordinate:' + coordinate);
    //console.log('region:' + region);
    //console.log('area:' + area);
    //console.log('sector:' + sector);

    //این بخش یه نگ تو نقطه ای که کلیک شده میزنه
    popup2.setPosition(coordinate);
    container.innerHTML = '<img src="/App_Themes/theme1/images/mappin.png" style="margin-left: -5px;margin-top:-17px; " />';
    //

    //ساخت نطقه به فرمت اس  کیو ال
    var sqlPoint = "POINT(" + coordinate[0] + " " + coordinate[1] + ")"
    //alert(sqlPoint);
    $('#latlong').val(sqlPoint);
    overlay.setPosition(coordinate);
    setTimeout(function () { visidel(); }, 500);

    //alert(sqlPoint);
    // حالا میتونی متغیر بالا ره به یه صفحه دیگه بصور کوئری استرینگ بفرستی و اطلاعات دیگه را توی او صفحه بگیری - متونی با یه دستور جی کوئری پنجره باز کنی

});






var earthquakeStyle = new ol.style.Style({
    image: new ol.style.Icon({
      
          src: '/App_Themes/theme1/images/treered.png'
    })
});

//لایه نمایش نقاط بر روی نقشه جهت گزارش های مبتنی بر نقشه
var bbox = new ol.layer.Vector({
    source: new ol.source.GeoJSON()//,
    //style: styleFunction
    , style: earthquakeStyle
})
 map.addLayer(bbox);

var select = new ol.interaction.Select({
    layers: [bbox]
});


map.addInteraction(select);
var selectedFeatures = select.getFeatures();
selectedFeatures.on('add', function (event) {
    var i = 1;
 
     var feature = event.target.item(0);
     var mid = feature.get('id');
     alert(mid);
     var obj = {};
     obj.StreetType = feature.get('StreetType');
     obj.LicesnceType = feature.get('LicesnceType');
     obj.Region = feature.get('Region');
     obj.Count = feature.get('Count');
     obj.Bon = feature.get('Bon');
     obj.DatePick = feature.get('DatePick');
     obj.Address = feature.get('Address');
     obj.comment = feature.get('comment');
     obj.id = feature.get('id');

     SetParameter(obj);
     setTimeout(function () { visidel(); }, 500);

        //document.getElementById('txtid').value = feature.get('id');

    //OpenWin(40, 1, "تاریحچه پیام", "MessageHistory&ids=" + mid + "&dashId=2&compid=0")
   //  alert('ddddd');
    // alert(mid);
    //alert(url);
    // put the url of the feature into the photo-info div
    //$('#photo-info').html(url);
    // showReport();
});

//addnew, fdate, tdate, region, area, sector, group, subgroup, subcolor
function showReport() {
    var oobbjj = {};
    oobbjj.PersonalId = pid;
    $.ajax({
        url: "/WebService1.asmx/GetMapReport",
        data: "{oobbjj:" + JSON.stringify(oobbjj) + "}",
               // data: "{ 'fdate':'" + fdate + "','tdate':'" + tdate + "','region':'" + region + "','area':'" + area + "','sector':'" + sector + "','group':'" + group + "','subgroup':'" + subgroup + "','subcolor':'" + subcolor + "'  }",
         dataType: "json",
        type: "POST",
        contentType: "application/json; charset=utf-8",

        success: function (data) {
            //if (addnew == "1")
            //    bbox.getSource().clear();

            var format = new ol.format.GeoJSON({
                defaultDataProjection: 'EPSG:32639'
            })

            var features = format.readFeatures(data.d, {
                dataProjection: 'EPSG:32639',
                featureProjection: 'EPSG:32639'
            });
            
            bbox.getSource().addFeatures(features);

            console.log(features);
            console.log(
            format.writeFeatures(features, {
                dataProjection: 'EPSG:32639',
                featureProjection: 'EPSG:32639'
            })
            );
             //alert(features[0]);
             //  alert(data.d);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(arguments);
            alert(error);
        }
    });
    visidel();
}





















