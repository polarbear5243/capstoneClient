S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 31870
Date: 2017-06-01 02:32:45+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 31870, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00007c7e
r2   = 0x00000006, r3   = 0xb40544c0
r4   = 0x00000002, r5   = 0xb4054000
r6   = 0xb674e09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5e7c708
r10  = 0xb8f79b68, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbedfae34
lr   = 0xb6644f18, pc   = 0xb6643b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     68864 KB
Buffers:     76516 KB
Cached:     275128 KB
VmPeak:     135276 KB
VmSize:     133972 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29336 KB
VmRSS:       28520 KB
VmData:      45844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35844 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 31870 TID = 31870
31870 31874 31972 31973 31983 

Maps Information
af12e000 af92d000 rw-p [stack:31983]
b0e5b000 b0e6c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0e7c000 b0e81000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1311000 b1319000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b132b000 b1b2a000 rw-p [stack:31973]
b1b2a000 b1b2b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b3b000 b1b4f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b63000 b1b64000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b74000 b1b77000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b88000 b1b89000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b99000 b1b9b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bab000 b1bad000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bbd000 b1bcd000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bdd000 b1be9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bfb000 b23fa000 rw-p [stack:31972]
b272b000 b2732000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2745000 b274b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b275b000 b2787000 r-xp /opt/usr/apps/org.example.client/bin/client
b28e0000 b29c3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29fa000 b2a22000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a34000 b3233000 rw-p [stack:31874]
b3233000 b3235000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3245000 b324f000 r-xp /lib/libnss_files-2.20-2014.11.so
b3260000 b3269000 r-xp /lib/libnss_nis-2.20-2014.11.so
b327a000 b328b000 r-xp /lib/libnsl-2.20-2014.11.so
b329e000 b32a4000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32b5000 b32b6000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32de000 b32e5000 r-xp /usr/lib/libminizip.so.1.0.0
b32f5000 b32fa000 r-xp /usr/lib/libstorage.so.0.1
b330a000 b3369000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b337f000 b3393000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a3000 b33e7000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33f7000 b33ff000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b340f000 b343f000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3452000 b350b000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b351f000 b3572000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3583000 b359e000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ae000 b366f000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3682000 b3692000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a2000 b36af000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36c0000 b36c7000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36d7000 b3718000 r-xp /usr/lib/libmdm.so.1.2.12
b3728000 b3730000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b373f000 b374f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3770000 b37d0000 r-xp /usr/lib/libasound.so.2.0.0
b37e2000 b37e5000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37f5000 b37f8000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3808000 b380d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b381d000 b381e000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b382e000 b3839000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b384d000 b3854000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3864000 b386a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b387a000 b387f000 r-xp /usr/lib/libmmfsession.so.0.0.1
b388f000 b38aa000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ba000 b38c1000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d1000 b38d4000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38e5000 b3913000 r-xp /usr/lib/libidn.so.11.5.44
b3923000 b3939000 r-xp /usr/lib/libnghttp2.so.5.4.0
b394a000 b3954000 r-xp /usr/lib/libcares.so.2.1.0
b3964000 b396e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b397e000 b3980000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3990000 b3991000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a1000 b39a5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39b6000 b39de000 r-xp /usr/lib/libui-extension.so.0.1.0
b39ef000 b3a18000 r-xp /usr/lib/libturbojpeg.so
b3a38000 b3a3e000 r-xp /usr/lib/libgif.so.4.1.6
b3a4e000 b3a94000 r-xp /usr/lib/libcurl.so.4.3.0
b3aa5000 b3ac6000 r-xp /usr/lib/libexif.so.12.3.3
b3ae1000 b3af6000 r-xp /usr/lib/libtts.so
b3b07000 b3b0f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b1f000 b3be5000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c05000 b3cfd000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d1c000 b3dea000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e01000 b3e03000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e13000 b3e19000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e29000 b3e4c000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e5d000 b3e5f000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e6f000 b3e71000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e82000 b3e87000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e9e000 b3ea0000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eb0000 b3eb7000 r-xp /usr/lib/libsensord-share.so
b3ec7000 b3edf000 r-xp /usr/lib/libsensor.so.1.1.0
b3ef0000 b3ef3000 r-xp /usr/lib/libXv.so.1.0.0
b3f03000 b3f08000 r-xp /usr/lib/libutilX.so.1.1.0
b3f18000 b3f1d000 r-xp /usr/lib/libappcore-common.so.1.1
b3f2d000 b3f34000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f47000 b3f4b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f5c000 b403a000 r-xp /usr/lib/libCOREGL.so.4.0
b405a000 b405d000 r-xp /usr/lib/libuuid.so.1.3.0
b406d000 b4084000 r-xp /usr/lib/libblkid.so.1.1.0
b4095000 b4097000 r-xp /usr/lib/libXau.so.6.0.0
b40a7000 b40ee000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4100000 b4106000 r-xp /usr/lib/libjson-c.so.2.0.1
b4117000 b411b000 r-xp /usr/lib/libogg.so.0.7.1
b412b000 b414d000 r-xp /usr/lib/libvorbis.so.0.4.3
b415d000 b4241000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b425d000 b4260000 r-xp /usr/lib/libEGL.so.1.4
b4271000 b4277000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4287000 b4289000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4299000 b42a6000 r-xp /usr/lib/libGLESv2.so.2.0
b42b7000 b4319000 r-xp /usr/lib/libpixman-1.so.0.28.2
b432e000 b4346000 r-xp /usr/lib/libmount.so.1.1.0
b4358000 b436c000 r-xp /usr/lib/libxcb.so.1.1.0
b437c000 b4383000 r-xp /lib/libcrypt-2.20-2014.11.so
b43bb000 b43bd000 r-xp /usr/lib/libiri.so
b43cd000 b43d8000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43e9000 b441f000 r-xp /usr/lib/libpulse.so.0.16.2
b4430000 b4473000 r-xp /usr/lib/libsndfile.so.1.0.25
b4488000 b449d000 r-xp /lib/libexpat.so.1.5.2
b44af000 b456d000 r-xp /usr/lib/libcairo.so.2.11200.14
b4581000 b4589000 r-xp /usr/lib/libdrm.so.2.4.0
b4599000 b459c000 r-xp /usr/lib/libdri2.so.0.0.0
b45ac000 b45fa000 r-xp /usr/lib/libssl.so.1.0.0
b460f000 b461b000 r-xp /usr/lib/libeeze.so.1.13.0
b462c000 b4635000 r-xp /usr/lib/libethumb.so.1.13.0
b4645000 b4648000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4658000 b480f000 r-xp /usr/lib/libcrypto.so.1.0.0
b55fa000 b5603000 r-xp /usr/lib/libXi.so.6.1.0
b5613000 b5615000 r-xp /usr/lib/libXgesture.so.7.0.0
b5625000 b5629000 r-xp /usr/lib/libXtst.so.6.1.0
b5639000 b563f000 r-xp /usr/lib/libXrender.so.1.3.0
b564f000 b5655000 r-xp /usr/lib/libXrandr.so.2.2.0
b5665000 b5667000 r-xp /usr/lib/libXinerama.so.1.0.0
b5678000 b567b000 r-xp /usr/lib/libXfixes.so.3.1.0
b568b000 b5696000 r-xp /usr/lib/libXext.so.6.4.0
b56a6000 b56a8000 r-xp /usr/lib/libXdamage.so.1.1.0
b56b8000 b56ba000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56ca000 b57ac000 r-xp /usr/lib/libX11.so.6.3.0
b57c0000 b57c7000 r-xp /usr/lib/libXcursor.so.1.0.2
b57d7000 b57ef000 r-xp /usr/lib/libudev.so.1.6.0
b57f1000 b57f4000 r-xp /lib/libattr.so.1.1.0
b5804000 b5824000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5825000 b582a000 r-xp /usr/lib/libffi.so.6.0.2
b583b000 b5853000 r-xp /lib/libz.so.1.2.8
b5863000 b5865000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5875000 b594a000 r-xp /usr/lib/libxml2.so.2.9.2
b595f000 b59fa000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a16000 b5a19000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a29000 b5a42000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a53000 b5a64000 r-xp /lib/libresolv-2.20-2014.11.so
b5a78000 b5af2000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b07000 b5b09000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b19000 b5b20000 r-xp /usr/lib/libembryo.so.1.13.0
b5b30000 b5b3a000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b4b000 b5b63000 r-xp /usr/lib/libpng12.so.0.50.0
b5b74000 b5b97000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb8000 b5bcc000 r-xp /usr/lib/libector.so.1.13.0
b5bdd000 b5bf5000 r-xp /usr/lib/liblua-5.1.so
b5c06000 b5c5d000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c71000 b5c99000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5caa000 b5cbd000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cce000 b5d08000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d19000 b5d27000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d37000 b5d3f000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4f000 b5d5c000 r-xp /usr/lib/libeio.so.1.13.0
b5d6c000 b5d6e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d7e000 b5d83000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d93000 b5daa000 r-xp /usr/lib/libefreet.so.1.13.0
b5dbc000 b5ddc000 r-xp /usr/lib/libeldbus.so.1.13.0
b5dec000 b5e0c000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e0e000 b5e14000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e24000 b5e35000 r-xp /usr/lib/libemotion.so.1.13.0
b5e46000 b5e4d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e5d000 b5e6c000 r-xp /usr/lib/libeo.so.1.13.0
b5e7d000 b5e8f000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea0000 b5ea5000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb5000 b5ece000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ede000 b5efb000 r-xp /usr/lib/libeet.so.1.13.0
b5f14000 b5f5c000 r-xp /usr/lib/libeina.so.1.13.0
b5f6d000 b5f7d000 r-xp /usr/lib/libefl.so.1.13.0
b5f8e000 b6073000 r-xp /usr/lib/libicuuc.so.51.1
b6090000 b61d0000 r-xp /usr/lib/libicui18n.so.51.1
b61e7000 b621f000 r-xp /usr/lib/libecore_x.so.1.13.0
b6231000 b6234000 r-xp /lib/libcap.so.2.21
b6244000 b626d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b627e000 b6285000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6297000 b62ce000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62df000 b63ca000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63dd000 b6456000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6468000 b646d000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b647d000 b6487000 r-xp /usr/lib/libvconf.so.0.2.45
b6497000 b6499000 r-xp /usr/lib/libvasum.so.0.3.1
b64a9000 b64ab000 r-xp /usr/lib/libttrace.so.1.1
b64bb000 b64be000 r-xp /usr/lib/libiniparser.so.0
b64ce000 b64f4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6504000 b6509000 r-xp /usr/lib/libxdgmime.so.1.1.0
b651a000 b6531000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6542000 b65ad000 r-xp /lib/libm-2.20-2014.11.so
b65be000 b65c4000 r-xp /lib/librt-2.20-2014.11.so
b65d5000 b65e2000 r-xp /usr/lib/libunwind.so.8.0.1
b6618000 b673c000 r-xp /lib/libc-2.20-2014.11.so
b6751000 b676a000 r-xp /lib/libgcc_s-4.9.so.1
b677a000 b685c000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b686d000 b6897000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a8000 b68e4000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e6000 b6969000 r-xp /usr/lib/libedje.so.1.13.0
b697c000 b699a000 r-xp /usr/lib/libecore.so.1.13.0
b69ba000 b6b41000 r-xp /usr/lib/libevas.so.1.13.0
b6b76000 b6b8a000 r-xp /lib/libpthread-2.20-2014.11.so
b6b9e000 b6dd2000 r-xp /usr/lib/libelementary.so.1.13.0
b6e01000 b6e05000 r-xp /usr/lib/libsmack.so.1.0.0
b6e15000 b6e1c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2c000 b6e2e000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3e000 b6e41000 r-xp /usr/lib/libbundle.so.0.1.22
b6e51000 b6e53000 r-xp /lib/libdl-2.20-2014.11.so
b6e64000 b6e7c000 r-xp /usr/lib/libaul.so.0.1.0
b6e90000 b6e95000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea6000 b6eb3000 r-xp /usr/lib/liblptcp.so
b6ec5000 b6ec9000 r-xp /usr/lib/libsys-assert.so
b6eda000 b6efa000 r-xp /lib/ld-2.20-2014.11.so
b6f0b000 b6f10000 r-xp /usr/bin/launchpad-loader
b8ba3000 b8f94000 rw-p [heap]
beddb000 bedfc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31870)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6643b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
type:0x0, tId:931, bearerType:0, szDestination:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:48.453+0900 I/Sage    ( 1483): MintNetDocThread.c: MintNetDocThread_EnqueueDocTransactionL(139) > [Sage][MintNetDocThread] Copy and Enqueue Doc transaction, T:931, bearer:0
06-01 02:27:48.463+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:48.463+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 50000
06-01 02:27:48.463+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:48.463+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(147) > [Sage][MintNetTransaction] Destroy Resp event data Type:0x0 / T:927
06-01 02:27:48.463+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(137) > [Sage][MintNetTransaction] Destroy Req event data Type:0x0 / T:931
06-01 02:27:48.753+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(401) > [Sage][MintNetDocThread] Find new transaction Job; count = 1
06-01 02:27:48.753+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(418) > [Sage][MintNetDocThread] New transaction arrived, T:931/F:2306
06-01 02:27:48.753+0900 I/Sage    ( 1483): MintNetDocThread.c: __makeCurlEasyL(310) > [Sage][MintNetDocThread] curl_multi_add_handle T:931/F:2306
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(535) > [Sage][MintNetDocThread] Response: 0 - No error / T:931
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvt:771
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x303
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleResponseCL(482) > [Sage][MintNetTransaction] Net Response Arrived, type:0x0, tId:931, bearerType:0
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseHeader(333) > [Sage][MintXmlDecoder] Can't resolve attribute, name = name, strId = 195
06-01 02:27:49.044+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseBody(186) > [Sage][MintXmlDecoder] Can't find node-value, Key = odcUrl
06-01 02:27:49.044+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(389) > [Sage][SageBizlogicSelfUpdate] __RecvCheckAppUp()
06-01 02:27:49.044+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(404) > [Sage][SageBizlogicSelfUpdate] Xml Response Callback tId = 931
06-01 02:27:49.044+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(414) > [Sage][SageBizlogicSelfUpdate] hasUpdate: 0
06-01 02:27:49.044+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(416) > [Sage][SageBizlogicSelfUpdate] pkgId: org.tizen.tizenstore
06-01 02:27:49.044+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(423) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->hasKillApp = 1
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(424) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->hasEmergencyUpdate = 0
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(438) > [Sage][SageBizlogicSelfUpdate] pCheckPeriod = 48|48|48|24|24|24
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(457) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->updatePeriodODC = 48
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(458) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->updatePeriodIAP = 48
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(459) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->updatePeriodAPP = 24
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(460) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->updatePeriodKillApp = 24
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(461) > [Sage][SageBizlogicSelfUpdate] gpstUpdateData->updatePeriodEmergency = 24
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(73) > [Sage][SageBizlogicSelfUpdate] __DoNext()
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(76) > [Sage][SageBizlogicSelfUpdate] Current status = 2
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(277) > [Sage][SageBizlogicSelfUpdate] __SendCheckAppUp() [type = 2]
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(218) > [Sage][SageBizlogicSelfUpdate] __CheckCondition1()
06-01 02:27:49.054+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: _preference_check_retry_err(467) > key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi), check retry err: -21/(2/No such file or directory).
06-01 02:27:49.054+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: _preference_get_key(1043) > _preference_get_key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi) step(-17825744) failed(2 / No such file or directory)
06-01 02:27:49.054+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: preference_get_int(1078) > preference_get_int(1483) : key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi) error
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(233) > [Sage][SageBizlogicSelfUpdate] isAutoUpdateOnIndigo[1] /isOnlyWifiIndigo[1] / isOnlyWifiThyme[1]
06-01 02:27:49.054+0900 E/CAPI_NETWORK_WIFI( 1483): net_wifi.c: wifi_initialize(59) > Already initialized
06-01 02:27:49.054+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(239) > [Sage][SageBizLogicSelfUpdateBg] wifi_initialize() fail[-38]
06-01 02:27:49.064+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(244) > [Sage][SageBizlogicSelfUpdate] ret[0] / wifiState[3]
06-01 02:27:49.064+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(247) > [Sage][SageBizlogicSelfUpdate] isWifiOn[1] / isAutoUpdateOnIndigo[1] / isOnlyWifiIndigo[1] / isOnlyWifiThyme[1]
06-01 02:27:49.064+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(251) > [Sage][SageBizlogicSelfUpdate] conditionType = 2
06-01 02:27:49.064+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(270) > [Sage][SageBizlogicSelfUpdate] isPass = 1
06-01 02:27:49.064+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __GetPkgVersion(649) > [Sage][SageBizlogicSelfUpdate] __GetPkgVersion()[type = 2]
06-01 02:27:49.064+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:49.064+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 300000
06-01 02:27:49.074+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __GetPkgVersion(719) > [Sage][SageBizlogicSelfUpdate] return pVersion [1.6.2]
06-01 02:27:49.074+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(367) > [Sage][SageBizlogicSelfUpFg] pVersion = 1.6.2
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintCommParamNet.c: MintCommParamNet_Generate_NetReqDocParam(247) > [Sage][MintCommParamNet] Secure URL replaced for F:2306, dest:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:49.074+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(373) > [Sage][SageBizlogicSelfUpdate] Id + Version = [com.samsung.themestore@1.6.2]
06-01 02:27:49.074+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(378) > [Sage][SageBizlogicSelfUpdate] pDoc->netBase.pUserData = com.samsung.themestore
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvt:770
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x302
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleRequestCL(317) > [Sage][MintNetTransaction] Net request Arrived, type:0x0, tId:935, bearerType:0, szDestination:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetDocThread.c: MintNetDocThread_EnqueueDocTransactionL(139) > [Sage][MintNetDocThread] Copy and Enqueue Doc transaction, T:935, bearer:0
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 50000
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(147) > [Sage][MintNetTransaction] Destroy Resp event data Type:0x0 / T:931
06-01 02:27:49.074+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(137) > [Sage][MintNetTransaction] Destroy Req event data Type:0x0 / T:935
06-01 02:27:49.364+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(401) > [Sage][MintNetDocThread] Find new transaction Job; count = 1
06-01 02:27:49.364+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(418) > [Sage][MintNetDocThread] New transaction arrived, T:935/F:2306
06-01 02:27:49.374+0900 I/Sage    ( 1483): MintNetDocThread.c: __makeCurlEasyL(310) > [Sage][MintNetDocThread] curl_multi_add_handle T:935/F:2306
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(535) > [Sage][MintNetDocThread] Response: 0 - No error / T:935
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvt:771
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x303
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleResponseCL(482) > [Sage][MintNetTransaction] Net Response Arrived, type:0x0, tId:935, bearerType:0
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseHeader(333) > [Sage][MintXmlDecoder] Can't resolve attribute, name = name, strId = 195
06-01 02:27:49.664+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseBody(186) > [Sage][MintXmlDecoder] Can't find node-value, Key = odcUrl
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(389) > [Sage][SageBizlogicSelfUpdate] __RecvCheckAppUp()
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(404) > [Sage][SageBizlogicSelfUpdate] Xml Response Callback tId = 935
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(414) > [Sage][SageBizlogicSelfUpdate] hasUpdate: 0
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(416) > [Sage][SageBizlogicSelfUpdate] pkgId: com.samsung.themestore
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(73) > [Sage][SageBizlogicSelfUpdate] __DoNext()
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(76) > [Sage][SageBizlogicSelfUpdate] Current status = 3
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(277) > [Sage][SageBizlogicSelfUpdate] __SendCheckAppUp() [type = 3]
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(218) > [Sage][SageBizlogicSelfUpdate] __CheckCondition1()
06-01 02:27:49.664+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: _preference_check_retry_err(467) > key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi), check retry err: -21/(2/No such file or directory).
06-01 02:27:49.664+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: _preference_get_key(1043) > _preference_get_key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi) step(-17825744) failed(2 / No such file or directory)
06-01 02:27:49.664+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: preference_get_int(1078) > preference_get_int(1483) : key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi) error
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(233) > [Sage][SageBizlogicSelfUpdate] isAutoUpdateOnIndigo[1] /isOnlyWifiIndigo[1] / isOnlyWifiThyme[1]
06-01 02:27:49.664+0900 E/CAPI_NETWORK_WIFI( 1483): net_wifi.c: wifi_initialize(59) > Already initialized
06-01 02:27:49.664+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(239) > [Sage][SageBizLogicSelfUpdateBg] wifi_initialize() fail[-38]
06-01 02:27:49.674+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(244) > [Sage][SageBizlogicSelfUpdate] ret[0] / wifiState[3]
06-01 02:27:49.674+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(247) > [Sage][SageBizlogicSelfUpdate] isWifiOn[1] / isAutoUpdateOnIndigo[1] / isOnlyWifiIndigo[1] / isOnlyWifiThyme[1]
06-01 02:27:49.674+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(251) > [Sage][SageBizlogicSelfUpdate] conditionType = 1
06-01 02:27:49.674+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(270) > [Sage][SageBizlogicSelfUpdate] isPass = 1
06-01 02:27:49.674+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __GetPkgVersion(649) > [Sage][SageBizlogicSelfUpdate] __GetPkgVersion()[type = 3]
06-01 02:27:49.674+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 300000
06-01 02:27:49.684+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __GetPkgVersion(719) > [Sage][SageBizlogicSelfUpdate] return pVersion [1.6.2]
06-01 02:27:49.684+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(367) > [Sage][SageBizlogicSelfUpFg] pVersion = 1.6.2
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintCommParamNet.c: MintCommParamNet_Generate_NetReqDocParam(247) > [Sage][MintCommParamNet] Secure URL replaced for F:2306, dest:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:49.684+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(373) > [Sage][SageBizlogicSelfUpdate] Id + Version = [org.tizen.inapppurchase@1.6.2]
06-01 02:27:49.684+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(378) > [Sage][SageBizlogicSelfUpdate] pDoc->netBase.pUserData = org.tizen.inapppurchase
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvt:770
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x302
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleRequestCL(317) > [Sage][MintNetTransaction] Net request Arrived, type:0x0, tId:939, bearerType:0, szDestination:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintNetDocThread.c: MintNetDocThread_EnqueueDocTransactionL(139) > [Sage][MintNetDocThread] Copy and Enqueue Doc transaction, T:939, bearer:0
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:49.684+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 50000
06-01 02:27:49.694+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:49.694+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(147) > [Sage][MintNetTransaction] Destroy Resp event data Type:0x0 / T:935
06-01 02:27:49.694+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(137) > [Sage][MintNetTransaction] Destroy Req event data Type:0x0 / T:939
06-01 02:27:49.985+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(401) > [Sage][MintNetDocThread] Find new transaction Job; count = 1
06-01 02:27:49.985+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(418) > [Sage][MintNetDocThread] New transaction arrived, T:939/F:2306
06-01 02:27:49.985+0900 I/Sage    ( 1483): MintNetDocThread.c: __makeCurlEasyL(310) > [Sage][MintNetDocThread] curl_multi_add_handle T:939/F:2306
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(535) > [Sage][MintNetDocThread] Response: 0 - No error / T:939
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvt:771
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x303
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleResponseCL(482) > [Sage][MintNetTransaction] Net Response Arrived, type:0x0, tId:939, bearerType:0
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseHeader(333) > [Sage][MintXmlDecoder] Can't resolve attribute, name = name, strId = 195
06-01 02:27:50.275+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseBody(186) > [Sage][MintXmlDecoder] Can't find node-value, Key = odcUrl
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(389) > [Sage][SageBizlogicSelfUpdate] __RecvCheckAppUp()
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(404) > [Sage][SageBizlogicSelfUpdate] Xml Response Callback tId = 939
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(414) > [Sage][SageBizlogicSelfUpdate] hasUpdate: 0
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(416) > [Sage][SageBizlogicSelfUpdate] pkgId: org.tizen.inapppurchase
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(73) > [Sage][SageBizlogicSelfUpdate] __DoNext()
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(76) > [Sage][SageBizlogicSelfUpdate] Current status = 4
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(277) > [Sage][SageBizlogicSelfUpdate] __SendCheckAppUp() [type = 4]
06-01 02:27:50.275+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(218) > [Sage][SageBizlogicSelfUpdate] __CheckCondition1()
06-01 02:27:50.285+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: _preference_check_retry_err(467) > key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi), check retry err: -21/(2/No such file or directory).
06-01 02:27:50.285+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: _preference_get_key(1043) > _preference_get_key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi) step(-17825744) failed(2 / No such file or directory)
06-01 02:27:50.285+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1483): preference.c: preference_get_int(1078) > preference_get_int(1483) : key(Preperence_Key_Update_ThymeAutoUpdaeOnlyWifi) error
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(233) > [Sage][SageBizlogicSelfUpdate] isAutoUpdateOnIndigo[1] /isOnlyWifiIndigo[1] / isOnlyWifiThyme[1]
06-01 02:27:50.285+0900 E/CAPI_NETWORK_WIFI( 1483): net_wifi.c: wifi_initialize(59) > Already initialized
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(239) > [Sage][SageBizLogicSelfUpdateBg] wifi_initialize() fail[-38]
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(244) > [Sage][SageBizlogicSelfUpdate] ret[0] / wifiState[3]
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(247) > [Sage][SageBizlogicSelfUpdate] isWifiOn[1] / isAutoUpdateOnIndigo[1] / isOnlyWifiIndigo[1] / isOnlyWifiThyme[1]
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(251) > [Sage][SageBizlogicSelfUpdate] conditionType = 0
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __CheckCondition(270) > [Sage][SageBizlogicSelfUpdate] isPass = 1
06-01 02:27:50.285+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __GetPkgVersion(649) > [Sage][SageBizlogicSelfUpdate] __GetPkgVersion()[type = 4]
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 300000
06-01 02:27:50.295+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __GetPkgVersion(719) > [Sage][SageBizlogicSelfUpdate] return pVersion [1.6.2]
06-01 02:27:50.295+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(367) > [Sage][SageBizlogicSelfUpFg] pVersion = 1.6.2
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintCommParamNet.c: MintCommParamNet_Generate_NetReqDocParam(247) > [Sage][MintCommParamNet] Secure URL replaced for F:2306, dest:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:50.295+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(373) > [Sage][SageBizlogicSelfUpdate] Id + Version = [org.tizen.tizenstore.billingagent@1.6.2]
06-01 02:27:50.295+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(378) > [Sage][SageBizlogicSelfUpdate] pDoc->netBase.pUserData = org.tizen.tizenstore.billingagent
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvt:770
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x302
06-01 02:27:50.295+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleRequestCL(317) > [Sage][MintNetTransaction] Net request Arrived, type:0x0, tId:943, bearerType:0, szDestination:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:50.305+0900 I/Sage    ( 1483): MintNetDocThread.c: MintNetDocThread_EnqueueDocTransactionL(139) > [Sage][MintNetDocThread] Copy and Enqueue Doc transaction, T:943, bearer:0
06-01 02:27:50.305+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:50.305+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 50000
06-01 02:27:50.305+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__SendCheckAppUp, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:50.305+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(147) > [Sage][MintNetTransaction] Destroy Resp event data Type:0x0 / T:939
06-01 02:27:50.305+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(137) > [Sage][MintNetTransaction] Destroy Req event data Type:0x0 / T:943
06-01 02:27:50.595+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(401) > [Sage][MintNetDocThread] Find new transaction Job; count = 1
06-01 02:27:50.595+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(418) > [Sage][MintNetDocThread] New transaction arrived, T:943/F:2306
06-01 02:27:50.595+0900 I/Sage    ( 1483): MintNetDocThread.c: __makeCurlEasyL(310) > [Sage][MintNetDocThread] curl_multi_add_handle T:943/F:2306
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(535) > [Sage][MintNetDocThread] Response: 0 - No error / T:943
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvt:771
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x303
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleResponseCL(482) > [Sage][MintNetTransaction] Net Response Arrived, type:0x0, tId:943, bearerType:0
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseHeader(333) > [Sage][MintXmlDecoder] Can't resolve attribute, name = name, strId = 195
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseBody(186) > [Sage][MintXmlDecoder] Can't find node-value, Key = odcUrl
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(389) > [Sage][SageBizlogicSelfUpdate] __RecvCheckAppUp()
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(404) > [Sage][SageBizlogicSelfUpdate] Xml Response Callback tId = 943
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(414) > [Sage][SageBizlogicSelfUpdate] hasUpdate: 0
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __RecvCheckAppUp(416) > [Sage][SageBizlogicSelfUpdate] pkgId: org.tizen.tizenstore.billingagent
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(73) > [Sage][SageBizlogicSelfUpdate] __DoNext()
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __DoNext(76) > [Sage][SageBizlogicSelfUpdate] Current status = 5
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicSelfUpdateBg.c: __EndStateSelfUpdate(150) > [Sage][SageBizlogicSelfUpdate] UpdateDate = 1 / 1 / 1 / 0 / 48 / 48 / 24 / 24 / 24 / http://ap-zircornia.tizenstore.com/ods.as / http://ap-zircornia.tizenstore.com/ods.as
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__EndStateSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvt:1801
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__EndStateSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1801
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicMain.c: SageBizLogicMain_HandleEventL(38) > [Sage][SageBizLogicMain] Sub event arrived type = 0x709
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicInit.c: SageBizlogicInit_SelfUpdateComplete(533) > [Sage][SageBizLogicInit] SageBizlogicInit_SelfUpComplete()
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicInit.c: SageBizlogicInit_SelfUpdateComplete(548) > [Sage][SageBizLogicInit] UpdateDate = 1 / 1 / 1 / 0 / 48 / 48 / 24 / 24 / 24 / http://ap-zircornia.tizenstore.com/ods.as / http://ap-zircornia.tizenstore.com/ods.as
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 5
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendCheckAppUpIndigo(560) > [Sage][SageBizLogicInit] __SendCheckAppUpIndigo()
06-01 02:27:50.895+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendCheckAppUpIndigo(565) > [Sage][SageBizLogicInit] CheckAppUp of Indigo aleady completed by BizLogicSelfUpdate module
06-01 02:27:50.895+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:50.905+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 300000
06-01 02:27:50.905+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendCheckAppUpIndigo(604) > [Sage][SageBizLogicInit] minPeriod = 24
06-01 02:27:50.905+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SetAlarmCheckAppUp(1105) > [Sage][SageBizLogicInit] __SetAlarmCheckAppUp()[24]
06-01 02:27:50.905+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __get_zone_name(506) > zone name [/]
06-01 02:27:50.905+0900 W/ALARM_MANAGER(  634): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1483/status successfully
06-01 02:27:50.905+0900 W/ALARM_MANAGER(  634): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 5000
06-01 02:27:50.915+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 02:27:50.925+0900 E/ALARM_MANAGER(  634): alarm-manager.c: alarm_manager_alarm_delete_all(3052) > alarm_id[723156999] is removed.
06-01 02:27:50.925+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-01 02:27:50.925+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 31-5-2017, 17:46:20 (UTC).
06-01 02:27:50.925+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-01 02:27:50.925+0900 E/ALARM_MANAGER( 1483): alarm-lib.c: __alarmmgr_init_appsvc(690) > alarm was already initialized.
06-01 02:27:50.955+0900 E/ALARM_MANAGER( 1483): alarm-lib.c: alarmmgr_add_alarm_appsvc(1092) > trigger_at_time(86400), start(2-6-2017, 02:27:51), repeat(1), interval(600), type(-2147483640)
06-01 02:27:50.965+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __get_zone_name(506) > zone name [/]
06-01 02:27:50.965+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 02:27:50.976+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 02:27:51.006+0900 E/ALARM_MANAGER(  634): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 550185710, next duetime: 1496339022
06-01 02:27:51.006+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(550185710)
06-01 02:27:51.006+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __alarm_create_appsvc(1048) > [alarm-server]:alarm_context.c_due_time(1496252780), due_time(1496339022)
06-01 02:27:51.006+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-01 02:27:51.006+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 31-5-2017, 17:46:20 (UTC).
06-01 02:27:51.006+0900 E/ALARM_MANAGER(  634): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 6
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendCheckAppUpThyme(791) > [Sage][SageBizLogicInit] __SendCheckAppUpODC()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendCheckAppUpThyme(796) > [Sage][SageBizLogicInit] CheckAppUp of Indigo aleady completed by BizLogicSelfUpdate module
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 7
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendRequestUpdate(905) > [Sage][SageBizLogicInit] __SendRequestUpdate()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __SendRequestUpdate(908) > [Sage][SageBizLogicInit] MintConfig_GetUserId() [(null)]
06-01 02:27:51.016+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__SendRequestUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvt:1796
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 8
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 9
06-01 02:27:51.016+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION, subEvt:1030
06-01 02:27:51.016+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION_THYME, subEvt:1106
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 10
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __UpdateLanvd(974) > [Sage][SageBizLogicInit] __UpdateLanvd()
06-01 02:27:51.016+0900 I/Sage    ( 1483): SageBizLogicInit.c: __UpdateLanvd(979) > [Sage][SageBizLogicInit] Lavend path = /opt/usr/apps/org.tizen.tizenstoreservice/res/org.tizen.tizenstore.billingagent-1.3.4-arm.tpk
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicInit.c: __UpdateLanvd(996) > [Sage][SageBizLogicInit] pLavndVersion = 1.6.2
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicInit.c: __ResetInitData(135) > [Sage][SageBizLogicInit] __ResetInitData()
06-01 02:27:51.026+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__EndStateSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1801
06-01 02:27:51.026+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__SendRequestUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1796
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicMain.c: SageBizLogicMain_HandleEventL(38) > [Sage][SageBizLogicMain] Sub event arrived type = 0x704
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: SageBizLogicUpdate_SetAction(133) > [Sage][SageBizLogicUpdate] SageBizLogicUpdate_SetAction()[1796]
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __Initialize(148) > [Sage][SageBizLogicUpdate] __Initialize()
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ResetUpdateData(1681) > [Sage][SageBizLogicUpdate] __ResetUpdateData()
06-01 02:27:51.026+0900 E/CAPI_NETWORK_WIFI( 1483): net_wifi.c: wifi_initialize(59) > Already initialized
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __Initialize(188) > [Sage][SageBizLogicUpdate] wifi_initialize() fail[-38]
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __DecideState(201) > [Sage][SageBizLogicUpdate] Current State is 0
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __UpdateKillApp(232) > [Sage][SageBizLogicUpdate] __UpdateKillApp
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __UpdateKillApp(233) > [Sage][SageBizLogicUpdate] hasKillApp : 1
06-01 02:27:51.026+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ChackUpdatePeriod(1716) > [Sage][SageBizLogicUpdate] __ChackUpdatePeriod()
06-01 02:27:51.036+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ChackUpdatePeriod(1756) > [Sage][SageBizLogicUpdate] type = 1 / periodeVal = 24
06-01 02:27:51.036+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ChackUpdatePeriod(1760) > [Sage][SageBizLogicUpdate] (periodeVal != -1) && (preferenceID != ESAGE_PREFERENCEID_NONE)
06-01 02:27:51.036+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ChackUpdatePeriod(1765) > [Sage][SageBizLogicUpdate] ret == PREFERENCE_ERROR_NONE || latestTime > 0
06-01 02:27:51.036+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ChackUpdatePeriod(1770) > [Sage][SageBizLogicUpdate] appUpdatePeriod: latestTime = 1496164305 / curTime = 1496251671 / term = 87366 / periodeVal = 86400
06-01 02:27:51.036+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ChackUpdatePeriod(1780) > [Sage][SageBizLogicUpdate] curTime = ecore_time_unix_get();
06-01 02:27:51.036+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __SendKillList(255) > [Sage][SageBizLogicUpdate] __SendKillList
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintCommParamNet.c: MintCommParamNet_Generate_NetReqDocParam(247) > [Sage][MintCommParamNet] Secure URL replaced for F:2400, dest:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__SendKillList, mainEvent:EMINT_EVENT_NET, subEvt:770
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__SendRequestUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1796
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION, subEvent:1030
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION, subEvent:1030
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION_THYME, subEvent:1106
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION_THYME, subEvent:1106
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__SendKillList, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x302
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleRequestCL(317) > [Sage][MintNetTransaction] Net request Arrived, type:0x0, tId:951, bearerType:0, szDestination:http://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintCommParamNet.c: MintCommParamNet_Duplicate_NetReqDocParam(302) > [Sage][MintCommParamNet] Secure URL replaced for F:2400, dest:https://ap-odc.tizenstore.com/zs/ods.as
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintNetDocThread.c: MintNetDocThread_EnqueueDocTransactionL(139) > [Sage][MintNetDocThread] Copy and Enqueue Doc transaction, T:951, bearer:0
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:51.036+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 50000
06-01 02:27:51.046+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__SendKillList, mainEvent:EMINT_EVENT_NET, subEvent:770
06-01 02:27:51.046+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(147) > [Sage][MintNetTransaction] Destroy Resp event data Type:0x0 / T:943
06-01 02:27:51.046+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(137) > [Sage][MintNetTransaction] Destroy Req event data Type:0x0 / T:951
06-01 02:27:51.206+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(401) > [Sage][MintNetDocThread] Find new transaction Job; count = 1
06-01 02:27:51.206+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(418) > [Sage][MintNetDocThread] New transaction arrived, T:951/F:2400
06-01 02:27:51.206+0900 I/Sage    ( 1483): MintNetDocThread.c: __makeCurlEasyL(310) > [Sage][MintNetDocThread] curl_multi_add_handle T:951/F:2400
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintNetDocThread.c: __MintNetDocThread_Main(535) > [Sage][MintNetDocThread] Response: 0 - No error / T:951
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(155) > [Sage][MintEventHandler] Sending event from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvt:771
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event received, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_HandleEventL(91) > [Sage][MintNetTransaction] Sub event arrived type = 0x303
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: __HandleResponseCL(482) > [Sage][MintNetTransaction] Net Response Arrived, type:0x0, tId:951, bearerType:0
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintXmlDecoder.c: __ParseResponseHeader(333) > [Sage][MintXmlDecoder] Can't resolve attribute, name = name, strId = 195
06-01 02:27:51.406+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ReceiveKillListCb(288) > [Sage][SageBizLogicUpdate] __ReceiveKillListCb
06-01 02:27:51.406+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ReceiveKillListCb(307) > [Sage][SageBizLogicUpdate] Xml Response Callback tId = 951
06-01 02:27:51.406+0900 E/PKGMGR  ( 1483): pkgmgr.c: pkgmgr_client_uninstall(2142) > uninstall pkg start.
06-01 02:27:51.406+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(702) > [Sage][MintNetPkgThread] MintNetBinThread_DecideDuration()
06-01 02:27:51.416+0900 E/PKGMGR_INFO( 1483): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[CJW15W1126] not found in DB
06-01 02:27:51.416+0900 I/Sage    ( 1483): MintNetDocThread.c: __DecideSleepIntervalDoc(733) > [Sage][MintNetPkgThread] gSleepInterval = 300000
06-01 02:27:51.416+0900 E/PKGMGR  ( 1483): pkgmgr.c: pkgmgr_client_uninstall(2177) > [0;31m[pkgmgr_client_uninstall(): 2177](ret < 0) pkgmgrinfo_pkginfo_get_pkginfo fail[0;m
06-01 02:27:51.416+0900 E/PKGMGR_INFO( 1483): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1808) > (handle == NULL) pkginfo handle is NULL
06-01 02:27:51.416+0900 E/PKGMGR  ( 1483): pkgmgr.c: pkgmgr_client_uninstall(2270) > uninstall pkg finish, ret=[-3]
06-01 02:27:51.416+0900 E/CAPI_APPFW_PACKAGE_MANAGER( 1483): package_manager.c: package_manager_error(138) > [package_manager_request_uninstall] INVALID_PARAMETER(0xffffffea)
06-01 02:27:51.416+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ReceiveKillListCb(326) > [Sage][SageBizLogicUpdate] package_manager_request_uninstall() fail
06-01 02:27:51.416+0900 E/PKGMGR  ( 1483): pkgmgr.c: pkgmgr_client_uninstall(2142) > uninstall pkg start.
06-01 02:27:51.426+0900 E/PKGMGR_INFO( 1483): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[sefsefefeee0001] not found in DB
06-01 02:27:51.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: pkgmgr_client_uninstall(2177) > [0;31m[pkgmgr_client_uninstall(): 2177](ret < 0) pkgmgrinfo_pkginfo_get_pkginfo fail[0;m
06-01 02:27:51.426+0900 E/PKGMGR_INFO( 1483): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1808) > (handle == NULL) pkginfo handle is NULL
06-01 02:27:51.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: pkgmgr_client_uninstall(2270) > uninstall pkg finish, ret=[-3]
06-01 02:27:51.426+0900 E/CAPI_APPFW_PACKAGE_MANAGER( 1483): package_manager.c: package_manager_error(138) > [package_manager_request_uninstall] INVALID_PARAMETER(0xffffffea)
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ReceiveKillListCb(326) > [Sage][SageBizLogicUpdate] package_manager_request_uninstall() fail
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __DecideState(201) > [Sage][SageBizLogicUpdate] Current State is 1
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __UpdateAppUpdateCount(339) > [Sage][SageBizLogicUpdate] __UpdateAppUpdateCount()
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __DecideState(201) > [Sage][SageBizLogicUpdate] Current State is 2
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __UpdateEmergencyUpdate(1414) > [Sage][SageBizLogicUpdate] __UpdateEmergencyUpdate
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __UpdateEmergencyUpdate(1415) > [Sage][SageBizLogicUpdate] hasEmergencyUpdate : 0
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __UpdateEmergencyUpdate(1421) > [Sage][SageBizLogicUpdate] !__updateData.hasEmergencyUpdate || !__ChackUpdatePeriod(ESAGE_BIZLOGIC_UPDATE_LEATESTUPDATECHECKTIME_EMERGENCYAPP)
06-01 02:27:51.436+0900 I/Sage    ( 1483): SageBizLogicUpdate.c: __ResetUpdateData(1681) > [Sage][SageBizLogicUpdate] __ResetUpdateData()
06-01 02:27:51.436+0900 I/Sage    ( 1483): MintEventHandler.c: __eventHandler_Main_Callback(258) > [Sage][MintEventHandler] Event finished, from:__MintNetDocThread_Main, mainEvent:EMINT_EVENT_NET, subEvent:771
06-01 02:27:51.436+0900 I/Sage    ( 1483): MintNetTransactionHandler.c: MintNetTransaction_FreeEventData(147) > [Sage][MintNetTransaction] Destroy Resp event data Type:0x0 / T:951
06-01 02:32:46.133+0900 W/CRASH_MANAGER(32613): worker.c: worker_job(1199) > 0631870636c69149625196
