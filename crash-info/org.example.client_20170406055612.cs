S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2430
Date: 2017-04-06 05:56:12+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2430, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000097e
r2   = 0x00000006, r3   = 0xb41104c0
r4   = 0x00000002, r5   = 0xb4110000
r6   = 0xb680a09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f38708
r10  = 0xb8793a38, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbecccc1c
lr   = 0xb6700f18, pc   = 0xb66ffb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    186724 KB
Buffers:     39320 KB
Cached:     315212 KB
VmPeak:     133916 KB
VmSize:     133912 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28332 KB
VmRSS:       28332 KB
VmData:      45852 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2430 TID = 2430
2430 2431 2463 2464 2472 

Maps Information
af22e000 afa2d000 rw-p [stack:2472]
b0fb5000 b0fc6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fd6000 b0fdb000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13dd000 b13e5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13f7000 b1bf6000 rw-p [stack:2464]
b1bf6000 b1bf7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c07000 b1c1b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c2f000 b1c30000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c40000 b1c43000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c54000 b1c55000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c65000 b1c67000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c77000 b1c79000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c89000 b1c99000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ca9000 b1cb5000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cc7000 b24c6000 rw-p [stack:2463]
b27f7000 b27fe000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2811000 b2817000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2827000 b2843000 r-xp /opt/usr/apps/org.example.client/bin/client
b299c000 b2a7f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ab6000 b2ade000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2af0000 b32ef000 rw-p [stack:2431]
b32ef000 b32f1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3301000 b330b000 r-xp /lib/libnss_files-2.20-2014.11.so
b331c000 b3325000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3336000 b3347000 r-xp /lib/libnsl-2.20-2014.11.so
b335a000 b3360000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3371000 b3372000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b339a000 b33a1000 r-xp /usr/lib/libminizip.so.1.0.0
b33b1000 b33b6000 r-xp /usr/lib/libstorage.so.0.1
b33c6000 b3425000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b343b000 b344f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b345f000 b34a3000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34b3000 b34bb000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34cb000 b34fb000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b350e000 b35c7000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35db000 b362e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b363f000 b365a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b366a000 b372b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b373e000 b374e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b375e000 b376b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b377c000 b3783000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3793000 b37d4000 r-xp /usr/lib/libmdm.so.1.2.12
b37e4000 b37ec000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37fb000 b380b000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b382c000 b388c000 r-xp /usr/lib/libasound.so.2.0.0
b389e000 b38a1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38b1000 b38b4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38c4000 b38c9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38d9000 b38da000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ea000 b38f5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3909000 b3910000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3920000 b3926000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3936000 b393b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b394b000 b3966000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3976000 b397d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b398d000 b3990000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39a1000 b39cf000 r-xp /usr/lib/libidn.so.11.5.44
b39df000 b39f5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a06000 b3a10000 r-xp /usr/lib/libcares.so.2.1.0
b3a20000 b3a2a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a3a000 b3a3c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a4c000 b3a4d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a5d000 b3a61000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a72000 b3a9a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aab000 b3ad4000 r-xp /usr/lib/libturbojpeg.so
b3af4000 b3afa000 r-xp /usr/lib/libgif.so.4.1.6
b3b0a000 b3b50000 r-xp /usr/lib/libcurl.so.4.3.0
b3b61000 b3b82000 r-xp /usr/lib/libexif.so.12.3.3
b3b9d000 b3bb2000 r-xp /usr/lib/libtts.so
b3bc3000 b3bcb000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bdb000 b3ca1000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cc1000 b3db9000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dd8000 b3ea6000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ebd000 b3ebf000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ecf000 b3ed5000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ee5000 b3f08000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f19000 b3f1b000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f2b000 b3f2d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f3e000 b3f43000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f5a000 b3f5c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f6c000 b3f73000 r-xp /usr/lib/libsensord-share.so
b3f83000 b3f9b000 r-xp /usr/lib/libsensor.so.1.1.0
b3fac000 b3faf000 r-xp /usr/lib/libXv.so.1.0.0
b3fbf000 b3fc4000 r-xp /usr/lib/libutilX.so.1.1.0
b3fd4000 b3fd9000 r-xp /usr/lib/libappcore-common.so.1.1
b3fe9000 b3ff0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4003000 b4007000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4018000 b40f6000 r-xp /usr/lib/libCOREGL.so.4.0
b4116000 b4119000 r-xp /usr/lib/libuuid.so.1.3.0
b4129000 b4140000 r-xp /usr/lib/libblkid.so.1.1.0
b4151000 b4153000 r-xp /usr/lib/libXau.so.6.0.0
b4163000 b41aa000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41bc000 b41c2000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d3000 b41d7000 r-xp /usr/lib/libogg.so.0.7.1
b41e7000 b4209000 r-xp /usr/lib/libvorbis.so.0.4.3
b4219000 b42fd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4319000 b431c000 r-xp /usr/lib/libEGL.so.1.4
b432d000 b4333000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4343000 b4345000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4355000 b4362000 r-xp /usr/lib/libGLESv2.so.2.0
b4373000 b43d5000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ea000 b4402000 r-xp /usr/lib/libmount.so.1.1.0
b4414000 b4428000 r-xp /usr/lib/libxcb.so.1.1.0
b4438000 b443f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4477000 b4479000 r-xp /usr/lib/libiri.so
b4489000 b4494000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44a5000 b44db000 r-xp /usr/lib/libpulse.so.0.16.2
b44ec000 b452f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4544000 b4559000 r-xp /lib/libexpat.so.1.5.2
b456b000 b4629000 r-xp /usr/lib/libcairo.so.2.11200.14
b463d000 b4645000 r-xp /usr/lib/libdrm.so.2.4.0
b4655000 b4658000 r-xp /usr/lib/libdri2.so.0.0.0
b4668000 b46b6000 r-xp /usr/lib/libssl.so.1.0.0
b46cb000 b46d7000 r-xp /usr/lib/libeeze.so.1.13.0
b46e8000 b46f1000 r-xp /usr/lib/libethumb.so.1.13.0
b4701000 b4704000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4714000 b48cb000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b6000 b56bf000 r-xp /usr/lib/libXi.so.6.1.0
b56cf000 b56d1000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e1000 b56e5000 r-xp /usr/lib/libXtst.so.6.1.0
b56f5000 b56fb000 r-xp /usr/lib/libXrender.so.1.3.0
b570b000 b5711000 r-xp /usr/lib/libXrandr.so.2.2.0
b5721000 b5723000 r-xp /usr/lib/libXinerama.so.1.0.0
b5734000 b5737000 r-xp /usr/lib/libXfixes.so.3.1.0
b5747000 b5752000 r-xp /usr/lib/libXext.so.6.4.0
b5762000 b5764000 r-xp /usr/lib/libXdamage.so.1.1.0
b5774000 b5776000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5786000 b5868000 r-xp /usr/lib/libX11.so.6.3.0
b587c000 b5883000 r-xp /usr/lib/libXcursor.so.1.0.2
b5893000 b58ab000 r-xp /usr/lib/libudev.so.1.6.0
b58ad000 b58b0000 r-xp /lib/libattr.so.1.1.0
b58c0000 b58e0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e1000 b58e6000 r-xp /usr/lib/libffi.so.6.0.2
b58f7000 b590f000 r-xp /lib/libz.so.1.2.8
b591f000 b5921000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5931000 b5a06000 r-xp /usr/lib/libxml2.so.2.9.2
b5a1b000 b5ab6000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad2000 b5ad5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae5000 b5afe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b0f000 b5b20000 r-xp /lib/libresolv-2.20-2014.11.so
b5b34000 b5bae000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bc3000 b5bc5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd5000 b5bdc000 r-xp /usr/lib/libembryo.so.1.13.0
b5bec000 b5bf6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c07000 b5c1f000 r-xp /usr/lib/libpng12.so.0.50.0
b5c30000 b5c53000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c74000 b5c88000 r-xp /usr/lib/libector.so.1.13.0
b5c99000 b5cb1000 r-xp /usr/lib/liblua-5.1.so
b5cc2000 b5d19000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d2d000 b5d55000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d66000 b5d79000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d8a000 b5dc4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dd5000 b5de3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5df3000 b5dfb000 r-xp /usr/lib/libtbm.so.1.0.0
b5e0b000 b5e18000 r-xp /usr/lib/libeio.so.1.13.0
b5e28000 b5e2a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e3a000 b5e3f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e4f000 b5e66000 r-xp /usr/lib/libefreet.so.1.13.0
b5e78000 b5e98000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ea8000 b5ec8000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eca000 b5ed0000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ee0000 b5ef1000 r-xp /usr/lib/libemotion.so.1.13.0
b5f02000 b5f09000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f19000 b5f28000 r-xp /usr/lib/libeo.so.1.13.0
b5f39000 b5f4b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f5c000 b5f61000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f71000 b5f8a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f9a000 b5fb7000 r-xp /usr/lib/libeet.so.1.13.0
b5fd0000 b6018000 r-xp /usr/lib/libeina.so.1.13.0
b6029000 b6039000 r-xp /usr/lib/libefl.so.1.13.0
b604a000 b612f000 r-xp /usr/lib/libicuuc.so.51.1
b614c000 b628c000 r-xp /usr/lib/libicui18n.so.51.1
b62a3000 b62db000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ed000 b62f0000 r-xp /lib/libcap.so.2.21
b6300000 b6329000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b633a000 b6341000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6353000 b638a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b639b000 b6486000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6499000 b6512000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6524000 b6529000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6539000 b6543000 r-xp /usr/lib/libvconf.so.0.2.45
b6553000 b6555000 r-xp /usr/lib/libvasum.so.0.3.1
b6565000 b6567000 r-xp /usr/lib/libttrace.so.1.1
b6577000 b657a000 r-xp /usr/lib/libiniparser.so.0
b658a000 b65b0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65c0000 b65c5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65d6000 b65ed000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65fe000 b6669000 r-xp /lib/libm-2.20-2014.11.so
b667a000 b6680000 r-xp /lib/librt-2.20-2014.11.so
b6691000 b669e000 r-xp /usr/lib/libunwind.so.8.0.1
b66d4000 b67f8000 r-xp /lib/libc-2.20-2014.11.so
b680d000 b6826000 r-xp /lib/libgcc_s-4.9.so.1
b6836000 b6918000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6929000 b6953000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6964000 b69a0000 r-xp /usr/lib/libsystemd.so.0.4.0
b69a2000 b6a25000 r-xp /usr/lib/libedje.so.1.13.0
b6a38000 b6a56000 r-xp /usr/lib/libecore.so.1.13.0
b6a76000 b6bfd000 r-xp /usr/lib/libevas.so.1.13.0
b6c32000 b6c46000 r-xp /lib/libpthread-2.20-2014.11.so
b6c5a000 b6e8e000 r-xp /usr/lib/libelementary.so.1.13.0
b6ebd000 b6ec1000 r-xp /usr/lib/libsmack.so.1.0.0
b6ed1000 b6ed8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee8000 b6eea000 r-xp /usr/lib/libdlog.so.0.0.0
b6efa000 b6efd000 r-xp /usr/lib/libbundle.so.0.1.22
b6f0d000 b6f0f000 r-xp /lib/libdl-2.20-2014.11.so
b6f20000 b6f38000 r-xp /usr/lib/libaul.so.0.1.0
b6f4c000 b6f51000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f62000 b6f6f000 r-xp /usr/lib/liblptcp.so
b6f81000 b6f85000 r-xp /usr/lib/libsys-assert.so
b6f96000 b6fb6000 r-xp /lib/ld-2.20-2014.11.so
b6fc7000 b6fcc000 r-xp /usr/bin/launchpad-loader
b8410000 b87ef000 rw-p [heap]
becad000 becce000 rw-p [stack]
becad000 becce000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2430)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66ffb84) [/lib/libc.so.6] + 0x2bb84
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
list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:56:05.291+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:56:05.291+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:56:05.291+0900 E/INDICATOR(  663): ticker.c: _ticker_noti_detailed_changed_cb(1335) > check op_type
04-06 05:56:05.291+0900 I/QUICKPANEL(  868): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
04-06 05:56:05.301+0900 I/AUL     (  744): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-06 05:56:05.311+0900 I/AUL     (  744): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-06 05:56:05.311+0900 I/AUL     (  744): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-06 05:56:05.321+0900 I/AUL     (  744): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-06 05:56:05.321+0900 E/CAPI_APPFW_APP_MANAGER(  744): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
04-06 05:56:05.351+0900 W/STARTER (  741): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
04-06 05:56:05.361+0900 W/STARTER (  741): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
04-06 05:56:05.361+0900 E/EFL     ( 2234): ecore_x<2234> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=522321
04-06 05:56:05.391+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:56:05.391+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:56:05.391+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:56:05.391+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:56:05.391+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:56:05.391+0900 E/INDICATOR(  663): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
04-06 05:56:05.391+0900 E/QUICKPANEL(  868): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
04-06 05:56:05.391+0900 I/QUICKPANEL(  868): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: shot-tizen, insert: 1[0;m
04-06 05:56:05.401+0900 E/EFL     (  853): ecore_x<853> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=522321
04-06 05:56:05.401+0900 E/QUICKPANEL(  868): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-06 05:56:05.401+0900 E/QUICKPANEL(  868): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-06 05:56:05.411+0900 E/QUICKPANEL(  868): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-06 05:56:05.411+0900 W/QUICKPANEL(  868): NotificationItemModel.cpp: __addNotification(637) > [0;35mshot-tizen - notification is inserted.[0;m
04-06 05:56:05.421+0900 I/QUICKPANEL(  868): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
04-06 05:56:05.421+0900 W/QUICKPANEL(  868): NotificationItemModel.cpp: insertNotification(237) > [0;35mEvent notification is inserted.[0;m
04-06 05:56:05.421+0900 E/EFL     (  868): eo<868> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
04-06 05:56:05.421+0900 I/QUICKPANEL(  868): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
04-06 05:56:05.441+0900 E/EFL     (  868): edje<868> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/listitem/notification has a non-fixed part 'elm.text.time'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-06 05:56:05.661+0900 I/SYSPOPUP(  866): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 05:56:05.661+0900 E/STARTER (  741): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 05:56:05.661+0900 E/STARTER (  741): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 05:56:05.661+0900 E/STARTER (  741): )
04-06 05:56:05.661+0900 I/SYSPOPUP(  866): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 05:56:05.661+0900 E/VOLUME  (  866): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 05:56:05.661+0900 E/VOLUME  (  866): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 05:56:05.671+0900 W/AUL     (  741): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
04-06 05:56:05.671+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:56:05.681+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-06 05:56:05.681+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:56:05.681+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 741
04-06 05:56:05.681+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:56:05.691+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:56:05.691+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:56:05.691+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:56:05.691+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:56:05.711+0900 I/GXT_SIB (  434): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 05:56:05.711+0900 E/CAPI_APPFW_APPLICATION( 2131): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:56:05.711+0900 E/CAPI_APPFW_APPLICATION( 2131): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:56:05.711+0900 E/CAPI_APPFW_APPLICATION( 2131): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:56:05.711+0900 E/CAPI_APPFW_APPLICATION( 2131): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:56:05.711+0900 E/CAPI_APPFW_APPLICATION( 2131): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:56:05.711+0900 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:56:05.711+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6b936e9 in class 'Edje_Object'.
04-06 05:56:05.711+0900 E/UXT     (  434): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
04-06 05:56:05.721+0900 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:56:05.791+0900 W/TASK_MGR_LITE( 2131): task-mgr-lite.c: create_win(197) > changeable ui enabled success
04-06 05:56:05.791+0900 I/GXT_SIB ( 2131): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 05:56:05.801+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2131, appid: com.samsung.task-mgr
04-06 05:56:05.801+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:56:05.811+0900 E/RESOURCED(  665): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
04-06 05:56:05.821+0900 W/AUL     (  741): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2131)
04-06 05:56:05.831+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:05.831+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:05.851+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:56:05.851+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:56:05.871+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.871+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:56:05.881+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 05:56:05.881+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:56:05.881+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:56:05.881+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.881+0900 E/RUA     ( 2131): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 16, ncols : 5
04-06 05:56:05.891+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:56:05.891+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 2381
04-06 05:56:05.891+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:56:05.891+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:56:05.901+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_v2_cached(847) > is running missing app detected: org.example.client (2234)
04-06 05:56:05.901+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2234
04-06 05:56:05.901+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:56:05.901+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.911+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 05:56:05.911+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
04-06 05:56:05.911+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
04-06 05:56:05.911+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-06 05:56:05.921+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-06 05:56:05.931+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.951+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.961+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.971+0900 I/APP_CORE( 2131): appcore-efl.c: __do_app(514) > [APP 2131] Event: RESET State: CREATED
04-06 05:56:05.971+0900 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:56:05.971+0900 E/EFL     ( 2131): edje<2131> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:05.971+0900 E/EFL     ( 2131): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:05.971+0900 E/EFL     ( 2131): edje<2131> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:05.971+0900 E/EFL     ( 2131): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:05.971+0900 W/APP_CORE( 2131): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00003
04-06 05:56:05.981+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:56:05.981+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:05.991+0900 E/EFL     (  853): ecore_x<853> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=523104
04-06 05:56:05.991+0900 W/STARTER (  741): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-06 05:56:05.991+0900 E/EFL     ( 2234): ecore_x<2234> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=523104
04-06 05:56:05.991+0900 E/STARTER (  741): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 05:56:05.991+0900 E/STARTER (  741): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 05:56:05.991+0900 E/STARTER (  741): )
04-06 05:56:05.991+0900 I/SYSPOPUP(  866): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 05:56:06.001+0900 I/SYSPOPUP(  866): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 05:56:06.001+0900 E/VOLUME  (  866): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 05:56:06.001+0900 E/VOLUME  (  866): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 05:56:06.001+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:06.011+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:06.031+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:06.052+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:06.062+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:06.092+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2131) status(0)
04-06 05:56:06.092+0900 I/APP_CORE( 2234): appcore-efl.c: __do_app(514) > [APP 2234] Event: PAUSE State: RUNNING
04-06 05:56:06.092+0900 I/CAPI_APPFW_APPLICATION( 2234): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:56:06.092+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2131) status(0)
04-06 05:56:06.102+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2234) status(4)
04-06 05:56:06.102+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(2234)
04-06 05:56:06.102+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2234, appid: org.example.client, status: bg
04-06 05:56:06.102+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2131) status(3)
04-06 05:56:06.102+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:56:06.102+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:56:06.102+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(2131)
04-06 05:56:06.102+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2131, appid: com.samsung.task-mgr, status: fg
04-06 05:56:06.102+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:56:06.112+0900 I/APP_CORE( 2131): appcore-efl.c: __do_app(514) > [APP 2131] Event: RESUME State: CREATED
04-06 05:56:06.132+0900 I/APP_CORE( 2131): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:56:06.132+0900 I/APP_CORE( 2131): appcore-efl.c: __do_app(625) > [APP 2131] Initial Launching, call the resume_cb
04-06 05:56:06.132+0900 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:56:06.132+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 2234): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 32
04-06 05:56:06.132+0900 E/APP_CORE( 2234): appcore-efl.c: _capture_and_make_file(1619) > win[6000002] widget[720] height[1280]
04-06 05:56:06.132+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:56:06.602+0900 E/EFL     ( 2131): ecore_x<2131> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=523710
04-06 05:56:06.742+0900 E/EFL     ( 2131): ecore_x<2131> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=523854
04-06 05:56:06.882+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.293
04-06 05:56:06.892+0900 I/Tizen::App( 1248): (499) > LaunchedApp(com.samsung.task-mgr)
04-06 05:56:06.892+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for com.samsung.task-mgr, 2131.
04-06 05:56:07.052+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:56:07.052+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:56:07.052+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(2131)
04-06 05:56:07.052+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2131, appid: com.samsung.task-mgr, status: bg
04-06 05:56:07.052+0900 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:56:07.052+0900 W/TASK_MGR_LITE( 2131): task-mgr-lite.c: _pause_app(406) > 
04-06 05:56:07.052+0900 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:56:07.052+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:56:07.052+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2234
04-06 05:56:07.052+0900 W/AUL     ( 2131): launch.c: app_request_to_launchpad(396) > request cmd(4) to(2234)
04-06 05:56:07.052+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 4
04-06 05:56:07.062+0900 I/APP_CORE( 2234): appcore-efl.c: __do_app(514) > [APP 2234] Event: TERMINATE State: PAUSED
04-06 05:56:07.062+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(2234), cmd(4)
04-06 05:56:07.062+0900 W/AUL     ( 2131): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-06 05:56:07.062+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:56:07.062+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:56:07.062+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:56:07.062+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:56:07.072+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 2234): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-06 05:56:07.072+0900 E/APP_CORE( 2234): appcore-efl.c: _capture_and_make_file(1619) > win[6000002] widget[720] height[1280]
04-06 05:56:07.072+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:56:07.072+0900 E/APP_CORE( 2234): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 05:56:07.083+0900 I/CAPI_APPFW_APPLICATION( 2234): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:56:07.093+0900 E/TASK_MGR_LITE( 2131): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-06 05:56:07.103+0900 E/TASK_MGR_LITE( 2131): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
04-06 05:56:07.103+0900 E/APP_CORE( 2131): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-06 05:56:07.113+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:07.123+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 05:56:07.123+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:56:07.123+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:56:07.123+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 05:56:07.123+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 05:56:07.153+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 05:56:07.173+0900 I/MALI    ( 2131): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=2131   close drm_fd=30 
04-06 05:56:07.193+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:07.203+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 05:56:07.203+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:56:07.203+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 05:56:07.223+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:56:07.223+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:56:07.223+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 05:56:07.243+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:07.243+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:07.263+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [com.samsun] 
04-06 05:56:07.263+0900 I/Tizen::System( 1248): (273) > Current App[com.samsun] is already actived.
04-06 05:56:07.283+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:56:07.443+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2234 pgid = 2234
04-06 05:56:07.443+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(2234)
04-06 05:56:07.483+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:56:07.483+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:56:07.483+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 05:56:07.483+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[2234] terminate event is forwarded
04-06 05:56:07.483+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 05:56:07.483+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 2234, ]
04-06 05:56:07.483+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 05:56:07.483+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-06 05:56:07.483+0900 I/Tizen::App( 1248): (512) > Not registered pid(2234)
04-06 05:56:07.483+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-06 05:56:07.483+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:56:07.483+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 2234
04-06 05:56:07.493+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2234
04-06 05:56:07.493+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.294
04-06 05:56:07.513+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:56:07.513+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 2234.
04-06 05:56:07.553+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2131 pgid = 2131
04-06 05:56:07.553+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(2131)
04-06 05:56:07.583+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:56:07.583+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:56:07.583+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 05:56:07.593+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 2131
04-06 05:56:07.593+0900 I/Tizen::App( 1248): (243) > App[com.samsung.task-mgr] pid[2131] terminate event is forwarded
04-06 05:56:07.593+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 05:56:07.593+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [com.samsung.task-mgr, 2131, ]
04-06 05:56:07.593+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 05:56:07.593+0900 I/Tizen::App( 1248): (506) > TerminatedApp(com.samsung.task-mgr)
04-06 05:56:07.593+0900 I/Tizen::App( 1248): (512) > Not registered pid(2131)
04-06 05:56:07.593+0900 I/Tizen::System( 1248): (246) > Terminated app [com.samsung.task-mgr]
04-06 05:56:07.593+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:56:07.593+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2131
04-06 05:56:07.593+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2131
04-06 05:56:07.603+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:56:07.603+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for com.samsung.task-mgr, 2131.
04-06 05:56:08.023+0900 I/UXT     ( 2447): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:56:08.073+0900 E/TBM     ( 2447): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:56:08.073+0900 I/MALI    ( 2447): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=2447   open drm_fd=30 
04-06 05:56:08.204+0900 E/EFL     ( 2447): edje<2447> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:08.204+0900 E/EFL     ( 2447): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:08.214+0900 E/EFL     ( 2447): edje<2447> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:08.214+0900 E/EFL     ( 2447): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:08.214+0900 E/EFL     ( 2447): edje<2447> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:08.214+0900 E/EFL     ( 2447): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:08.244+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.244+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.264+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.264+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.274+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.274+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.294+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.294+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.314+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.314+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.334+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.334+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.354+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.354+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.364+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.374+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.384+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.394+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.404+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.404+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.424+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.424+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.444+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:08.444+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:08.464+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=525574
04-06 05:56:08.564+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=525672
04-06 05:56:08.564+0900 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:56:08.564+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:56:08.564+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 869
04-06 05:56:08.574+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 05:56:08.584+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:56:08.584+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:56:08.584+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:56:08.584+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:56:08.594+0900 I/abc     ( 2430): abc
04-06 05:56:08.594+0900 I/CAPI_APPFW_APPLICATION( 2430): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:56:08.594+0900 I/CAPI_APPFW_APPLICATION( 2430): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:56:08.624+0900 E/TBM     ( 2430): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:56:08.684+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2430, appid: org.example.client
04-06 05:56:08.684+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:56:08.694+0900 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(1) result(2430)
04-06 05:56:08.874+0900 D/basicui ( 2430): successed to load edc file
04-06 05:56:08.904+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:08.904+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:08.914+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:56:08.934+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:56:08.934+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:56:08.934+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:56:08.964+0900 I/MY_LOG  ( 2430): change
04-06 05:56:09.004+0900 I/APP_CORE( 2430): appcore-efl.c: __do_app(514) > [APP 2430] Event: RESET State: CREATED
04-06 05:56:09.004+0900 I/CAPI_APPFW_APPLICATION( 2430): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:56:09.014+0900 E/EFL     ( 2430): edje<2430> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:09.014+0900 E/EFL     ( 2430): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:09.024+0900 E/EFL     ( 2430): edje<2430> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:09.024+0900 E/EFL     ( 2430): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:09.024+0900 E/EFL     ( 2430): edje<2430> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:56:09.024+0900 E/EFL     ( 2430): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:56:09.034+0900 W/APP_CORE( 2430): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00002
04-06 05:56:09.034+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:56:09.135+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 05:56:09.135+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:56:09.135+0900 I/APP_CORE( 2430): appcore-efl.c: __do_app(514) > [APP 2430] Event: RESUME State: CREATED
04-06 05:56:09.135+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 05:56:09.145+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 05:56:09.145+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 05:56:09.145+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 05:56:09.145+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2430) status(3)
04-06 05:56:09.145+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(2430)
04-06 05:56:09.145+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2430, appid: org.example.client, status: fg
04-06 05:56:09.155+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:56:09.155+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:56:09.155+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 05:56:09.155+0900 I/APP_CORE( 2430): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:56:09.155+0900 I/APP_CORE( 2430): appcore-efl.c: __do_app(625) > [APP 2430] Initial Launching, call the resume_cb
04-06 05:56:09.155+0900 I/CAPI_APPFW_APPLICATION( 2430): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:56:09.505+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2430) status(0)
04-06 05:56:09.745+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.298
04-06 05:56:09.755+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-06 05:56:09.755+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 2430.
04-06 05:56:09.895+0900 W/MEDIA_THUMBNAIL_SERVER( 2435): thumb-server-internal.c: _thumb_server_read_socket(514) > [32mreceived KILL msg from thumbnail agent.
04-06 05:56:09.895+0900 W/MEDIA_THUMBNAIL_SERVER( 2435): thumb-server-internal.c: _thumb_server_read_socket(575) > [32mShutting down...
04-06 05:56:09.895+0900 E/MEDIA_THUMBNAIL_DCM( 2435): thumb-server-dcm.c: _thumb_server_dcm_quit_main_loop(445) > [31mInvalid DCM thread main loop![0m
04-06 05:56:10.035+0900 E/MEDIA_SERVER(  893): media-server-main.c: _ms_signal_handler(183) > [2435] Thumbnail server is stopped by media-server
04-06 05:56:10.035+0900 E/MEDIA_SERVER_THUMB(  893): media-server-thumb.c: ms_thumb_reset_server_status(162) > [no-err] g_thumb_server_extracting = 0 -> FALSE
04-06 05:56:10.326+0900 E/EFL     ( 2430): ecore_x<2430> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=527435
04-06 05:56:10.436+0900 E/EFL     ( 2430): ecore_x<2430> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=527546
04-06 05:56:10.546+0900 I/UXT     ( 2469): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:56:12.057+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:56:12.067+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:56:12.067+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:56:12.147+0900 E/EFL     ( 2430): ecore_x<2430> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=529250
04-06 05:56:12.147+0900 I/MY_LOG  ( 2430): Button pressed
04-06 05:56:12.278+0900 E/EFL     ( 2430): ecore_x<2430> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=529382
04-06 05:56:12.278+0900 E/VCONF   ( 2430): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:56:12.278+0900 E/VCONF   ( 2430): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:56:12.278+0900 E/VCONF   ( 2430): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:56:12.278+0900 E/VCONF   ( 2430): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2430) : db/ise/keysound error
04-06 05:56:12.278+0900 E/VCONF   ( 2430): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:56:12.278+0900 E/VCONF   ( 2430): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:56:12.338+0900 I/MY_LOG  ( 2430): Button unpressed
04-06 05:56:12.468+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2430 pgid = 2430
04-06 05:56:12.468+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(2430)
04-06 05:56:12.478+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:12.518+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 05:56:12.518+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:56:12.518+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:56:12.518+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 05:56:12.518+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 05:56:12.518+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 05:56:12.548+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 05:56:12.548+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:56:12.548+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 05:56:12.548+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:56:12.558+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:56:12.558+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:56:12.558+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 05:56:12.578+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 2430
04-06 05:56:12.578+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2430
04-06 05:56:12.578+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2430
04-06 05:56:12.578+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:56:12.578+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:56:12.578+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:56:12.578+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:56:12.578+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 05:56:12.598+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:56:12.598+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:56:12.598+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:56:12.598+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:56:12.598+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:56:12.598+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:56:12.598+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:56:12.608+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:56:12.608+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[2430] terminate event is forwarded
04-06 05:56:12.608+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 05:56:12.608+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 2430, ]
04-06 05:56:12.608+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 05:56:12.608+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-06 05:56:12.608+0900 I/Tizen::App( 1248): (512) > Not registered pid(2430)
04-06 05:56:12.608+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-06 05:56:12.608+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:56:12.668+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:56:12.668+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 2430.
04-06 05:56:12.688+0900 W/CRASH_MANAGER( 2475): worker.c: worker_job(1199) > 0602430636c69149142577
