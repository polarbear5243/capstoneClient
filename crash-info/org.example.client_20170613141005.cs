S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 18519
Date: 2017-06-13 14:10:05+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 18519, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004857
r2   = 0x00000006, r3   = 0xb40df4c0
r4   = 0x00000002, r5   = 0xb40df000
r6   = 0xb67d909c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb8ad1d38
r10  = 0xbeb34498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeb340ec
lr   = 0xb66cff18, pc   = 0xb66ceb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     54924 KB
Buffers:     64816 KB
Cached:     239588 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19620 KB
VmRSS:       19620 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 18519 TID = 18519
18519 18520 18870 

Maps Information
b1ba8000 b1bb0000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bc1000 b1bc2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd2000 b1be6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfa000 b1bfb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0b000 b1c0e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c1f000 b1c20000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c30000 b1c32000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c42000 b1c44000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c54000 b1c64000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c74000 b1c80000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c92000 b2491000 rw-p [stack:18870]
b27c2000 b27c9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27dc000 b27e2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f2000 b2822000 r-xp /opt/usr/apps/org.example.client/bin/client
b296b000 b2a4e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a85000 b2aad000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2abf000 b32be000 rw-p [stack:18520]
b32be000 b32c0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32d0000 b32da000 r-xp /lib/libnss_files-2.20-2014.11.so
b32eb000 b32f4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3305000 b3316000 r-xp /lib/libnsl-2.20-2014.11.so
b3329000 b332f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3340000 b3341000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3369000 b3370000 r-xp /usr/lib/libminizip.so.1.0.0
b3380000 b3385000 r-xp /usr/lib/libstorage.so.0.1
b3395000 b33f4000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b340a000 b341e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b342e000 b3472000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3482000 b348a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b349a000 b34ca000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34dd000 b3596000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35aa000 b35fd000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b360e000 b3629000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3639000 b36fa000 r-xp /usr/lib/libprotobuf.so.9.0.1
b370d000 b371d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b372d000 b373a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b374b000 b3752000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3762000 b37a3000 r-xp /usr/lib/libmdm.so.1.2.12
b37b3000 b37bb000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37ca000 b37da000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37fb000 b385b000 r-xp /usr/lib/libasound.so.2.0.0
b386d000 b3870000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3880000 b3883000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3893000 b3898000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38a8000 b38a9000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38b9000 b38c4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38d8000 b38df000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38ef000 b38f5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3905000 b390a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b391a000 b3935000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3945000 b394c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b395c000 b395f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3970000 b399e000 r-xp /usr/lib/libidn.so.11.5.44
b39ae000 b39c4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39d5000 b39df000 r-xp /usr/lib/libcares.so.2.1.0
b39ef000 b39f9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a09000 b3a0b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a1b000 b3a1c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a2c000 b3a30000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a41000 b3a69000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a7a000 b3aa3000 r-xp /usr/lib/libturbojpeg.so
b3ac3000 b3ac9000 r-xp /usr/lib/libgif.so.4.1.6
b3ad9000 b3b1f000 r-xp /usr/lib/libcurl.so.4.3.0
b3b30000 b3b51000 r-xp /usr/lib/libexif.so.12.3.3
b3b6c000 b3b81000 r-xp /usr/lib/libtts.so
b3b92000 b3b9a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3baa000 b3c70000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c90000 b3d88000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3da7000 b3e75000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e8c000 b3e8e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e9e000 b3ea4000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eb4000 b3ed7000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ee8000 b3eea000 r-xp /usr/lib/libappsvc.so.0.1.0
b3efa000 b3efc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f0d000 b3f12000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f29000 b3f2b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f3b000 b3f42000 r-xp /usr/lib/libsensord-share.so
b3f52000 b3f6a000 r-xp /usr/lib/libsensor.so.1.1.0
b3f7b000 b3f7e000 r-xp /usr/lib/libXv.so.1.0.0
b3f8e000 b3f93000 r-xp /usr/lib/libutilX.so.1.1.0
b3fa3000 b3fa8000 r-xp /usr/lib/libappcore-common.so.1.1
b3fb8000 b3fbf000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fd2000 b3fd6000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fe7000 b40c5000 r-xp /usr/lib/libCOREGL.so.4.0
b40e5000 b40e8000 r-xp /usr/lib/libuuid.so.1.3.0
b40f8000 b410f000 r-xp /usr/lib/libblkid.so.1.1.0
b4120000 b4122000 r-xp /usr/lib/libXau.so.6.0.0
b4132000 b4179000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b418b000 b4191000 r-xp /usr/lib/libjson-c.so.2.0.1
b41a2000 b41a6000 r-xp /usr/lib/libogg.so.0.7.1
b41b6000 b41d8000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e8000 b42cc000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42e8000 b42eb000 r-xp /usr/lib/libEGL.so.1.4
b42fc000 b4302000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4312000 b4314000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4324000 b4331000 r-xp /usr/lib/libGLESv2.so.2.0
b4342000 b43a4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b9000 b43d1000 r-xp /usr/lib/libmount.so.1.1.0
b43e3000 b43f7000 r-xp /usr/lib/libxcb.so.1.1.0
b4407000 b440e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4446000 b4448000 r-xp /usr/lib/libiri.so
b4458000 b4463000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4474000 b44aa000 r-xp /usr/lib/libpulse.so.0.16.2
b44bb000 b44fe000 r-xp /usr/lib/libsndfile.so.1.0.25
b4513000 b4528000 r-xp /lib/libexpat.so.1.5.2
b453a000 b45f8000 r-xp /usr/lib/libcairo.so.2.11200.14
b460c000 b4614000 r-xp /usr/lib/libdrm.so.2.4.0
b4624000 b4627000 r-xp /usr/lib/libdri2.so.0.0.0
b4637000 b4685000 r-xp /usr/lib/libssl.so.1.0.0
b469a000 b46a6000 r-xp /usr/lib/libeeze.so.1.13.0
b46b7000 b46c0000 r-xp /usr/lib/libethumb.so.1.13.0
b46d0000 b46d3000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46e3000 b489a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5685000 b568e000 r-xp /usr/lib/libXi.so.6.1.0
b569e000 b56a0000 r-xp /usr/lib/libXgesture.so.7.0.0
b56b0000 b56b4000 r-xp /usr/lib/libXtst.so.6.1.0
b56c4000 b56ca000 r-xp /usr/lib/libXrender.so.1.3.0
b56da000 b56e0000 r-xp /usr/lib/libXrandr.so.2.2.0
b56f0000 b56f2000 r-xp /usr/lib/libXinerama.so.1.0.0
b5703000 b5706000 r-xp /usr/lib/libXfixes.so.3.1.0
b5716000 b5721000 r-xp /usr/lib/libXext.so.6.4.0
b5731000 b5733000 r-xp /usr/lib/libXdamage.so.1.1.0
b5743000 b5745000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5755000 b5837000 r-xp /usr/lib/libX11.so.6.3.0
b584b000 b5852000 r-xp /usr/lib/libXcursor.so.1.0.2
b5862000 b587a000 r-xp /usr/lib/libudev.so.1.6.0
b587c000 b587f000 r-xp /lib/libattr.so.1.1.0
b588f000 b58af000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58b0000 b58b5000 r-xp /usr/lib/libffi.so.6.0.2
b58c6000 b58de000 r-xp /lib/libz.so.1.2.8
b58ee000 b58f0000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5900000 b59d5000 r-xp /usr/lib/libxml2.so.2.9.2
b59ea000 b5a85000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aa1000 b5aa4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ab4000 b5acd000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ade000 b5aef000 r-xp /lib/libresolv-2.20-2014.11.so
b5b03000 b5b7d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b92000 b5b94000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ba4000 b5bab000 r-xp /usr/lib/libembryo.so.1.13.0
b5bbb000 b5bc5000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bd6000 b5bee000 r-xp /usr/lib/libpng12.so.0.50.0
b5bff000 b5c22000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c43000 b5c57000 r-xp /usr/lib/libector.so.1.13.0
b5c68000 b5c80000 r-xp /usr/lib/liblua-5.1.so
b5c91000 b5ce8000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cfc000 b5d24000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d35000 b5d48000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d59000 b5d93000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5da4000 b5db2000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dc2000 b5dca000 r-xp /usr/lib/libtbm.so.1.0.0
b5dda000 b5de7000 r-xp /usr/lib/libeio.so.1.13.0
b5df7000 b5df9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e09000 b5e0e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e1e000 b5e35000 r-xp /usr/lib/libefreet.so.1.13.0
b5e47000 b5e67000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e77000 b5e97000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e99000 b5e9f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eaf000 b5ec0000 r-xp /usr/lib/libemotion.so.1.13.0
b5ed1000 b5ed8000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee8000 b5ef7000 r-xp /usr/lib/libeo.so.1.13.0
b5f08000 b5f1a000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f2b000 b5f30000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f40000 b5f59000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f69000 b5f86000 r-xp /usr/lib/libeet.so.1.13.0
b5f9f000 b5fe7000 r-xp /usr/lib/libeina.so.1.13.0
b5ff8000 b6008000 r-xp /usr/lib/libefl.so.1.13.0
b6019000 b60fe000 r-xp /usr/lib/libicuuc.so.51.1
b611b000 b625b000 r-xp /usr/lib/libicui18n.so.51.1
b6272000 b62aa000 r-xp /usr/lib/libecore_x.so.1.13.0
b62bc000 b62bf000 r-xp /lib/libcap.so.2.21
b62cf000 b62f8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6309000 b6310000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6322000 b6359000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b636a000 b6455000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6468000 b64e1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64f3000 b64f8000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6508000 b6512000 r-xp /usr/lib/libvconf.so.0.2.45
b6522000 b6524000 r-xp /usr/lib/libvasum.so.0.3.1
b6534000 b6536000 r-xp /usr/lib/libttrace.so.1.1
b6546000 b6549000 r-xp /usr/lib/libiniparser.so.0
b6559000 b657f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b658f000 b6594000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a5000 b65bc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65cd000 b6638000 r-xp /lib/libm-2.20-2014.11.so
b6649000 b664f000 r-xp /lib/librt-2.20-2014.11.so
b6660000 b666d000 r-xp /usr/lib/libunwind.so.8.0.1
b66a3000 b67c7000 r-xp /lib/libc-2.20-2014.11.so
b67dc000 b67f5000 r-xp /lib/libgcc_s-4.9.so.1
b6805000 b68e7000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f8000 b6922000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6933000 b696f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6971000 b69f4000 r-xp /usr/lib/libedje.so.1.13.0
b6a07000 b6a25000 r-xp /usr/lib/libecore.so.1.13.0
b6a45000 b6bcc000 r-xp /usr/lib/libevas.so.1.13.0
b6c01000 b6c15000 r-xp /lib/libpthread-2.20-2014.11.so
b6c29000 b6e5d000 r-xp /usr/lib/libelementary.so.1.13.0
b6e8c000 b6e90000 r-xp /usr/lib/libsmack.so.1.0.0
b6ea0000 b6ea7000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb7000 b6eb9000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec9000 b6ecc000 r-xp /usr/lib/libbundle.so.0.1.22
b6edc000 b6ede000 r-xp /lib/libdl-2.20-2014.11.so
b6eef000 b6f07000 r-xp /usr/lib/libaul.so.0.1.0
b6f1b000 b6f20000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f31000 b6f3e000 r-xp /usr/lib/liblptcp.so
b6f50000 b6f54000 r-xp /usr/lib/libsys-assert.so
b6f65000 b6f85000 r-xp /lib/ld-2.20-2014.11.so
b6f96000 b6f9b000 r-xp /usr/bin/launchpad-loader
b8a57000 b8c9c000 rw-p [heap]
beb14000 beb35000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18519)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66ceb84) [/lib/libc.so.6] + 0x2bb84
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
+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:09:52.255+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:09:52.255+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:09:52.265+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:09:52.265+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:09:52.265+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:09:52.455+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-13 14:09:52.455+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-13 14:09:52.455+0900 W/APP_CORE(  857): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-13 14:09:52.455+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: RESUME State: PAUSED
06-13 14:09:52.455+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:09:52.455+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-13 14:09:52.455+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-13 14:09:52.455+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:09:52.455+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-13 14:09:52.455+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:09:52.465+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 857
06-13 14:09:52.465+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 14:09:52.475+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 18730
06-13 14:09:52.475+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:09:52.525+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 18730
06-13 14:09:52.525+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 18730, appid: com.samsung.weather-m-agent
06-13 14:09:52.535+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(18730)
06-13 14:09:52.535+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 14:09:52.535+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 18730.
06-13 14:09:52.735+0900 E/weather-agent(18730): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 14:09:52.735+0900 E/weather-common(18730): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 14:09:52.735+0900 E/weather-agent(18730): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 14:09:52.735+0900 E/weather-common(18730): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 14:09:52.735+0900 E/weather-common(18730): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 14:09:52.735+0900 E/weather-common(18730): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 14:09:52.745+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 14:09:52.745+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 14:09:52.745+0900 I/MESSAGE_PORT(18730): message-port.c: __initialize(872) > initialize
06-13 14:09:52.745+0900 I/MESSAGE_PORT(18730): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-13 14:09:52.765+0900 E/PKGMGR  (18745): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:09:52.785+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:09:52.795+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-13 14:09:52.795+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:09:52.795+0900 E/MESSAGE_PORT(18730): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 14:09:52.795+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:09:52.795+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:09:52.795+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:09:52.795+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:09:52.805+0900 E/MESSAGE_PORT(18730): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:09:52.805+0900 E/weather-common(18730): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:09:52.805+0900 E/weather-agent(18730): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:09:52.805+0900 E/weather-agent(18730): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:09:52.805+0900 I/MESSAGE_PORT(18730): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:09:52.805+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:09:52.835+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:09:52.855+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17579055
06-13 14:09:52.875+0900 E/PKGMGR_SERVER(18749): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:09:52.875+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:09:52.875+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:09:52.875+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:09:52.875+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:09:52.875+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:09:52.885+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:09:52.885+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:09:52.885+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:09:52.895+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:09:52.895+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:09:52.905+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-13 14:09:52.945+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17579143
06-13 14:09:52.945+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 14:09:52.955+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:09:52.965+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:09:52.975+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:52.985+0900 E/PKGMGR_SERVER(18749): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 14:09:52.995+0900 E/PKGMGR_SERVER(18749): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 14:09:53.005+0900 E/PKGMGR  (18745): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[187450002]
06-13 14:09:53.215+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:53.215+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:53.215+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 14:09:53.215+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
06-13 14:09:53.225+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 14:09:53.235+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:09:53.235+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:09:53.235+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:09:53.246+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:53.246+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:53.486+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17579694
06-13 14:09:53.516+0900 E/rpm-installer(18753): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 14:09:53.516+0900 E/rpm-installer(18753): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 14:09:53.596+0900 E/PKGMGR_PARSER(18753): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 14:09:53.606+0900 I/PRIVACY-MANAGER-CLIENT(18753): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:09:53.606+0900 I/PRIVACY-MANAGER-CLIENT(18753): SocketClient.cpp: connect(62) > Client connected
06-13 14:09:53.606+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 14:09:53.616+0900 I/PRIVACY-MANAGER-CLIENT(18753): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 14:09:53.616+0900 E/PKGMGR_CERT(18753): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 14:09:53.616+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17579826
06-13 14:09:53.616+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-13 14:09:53.616+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-13 14:09:53.616+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:09:53.616+0900 E/PKGMGR_CERT(18753): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 14:09:53.636+0900 E/PKGMGR_CERT(18753): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 14:09:53.676+0900 E/rpm-installer(18753): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 14:09:53.686+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 14:09:53.686+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
06-13 14:09:53.686+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:53.686+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:53.696+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 14:09:53.706+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 14:09:53.706+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 14:09:53.706+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 14:09:53.806+0900 E/weather-agent(18730): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:09:53.806+0900 I/CAPI_APPFW_APPLICATION(18730): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:09:53.806+0900 E/weather-agent(18730): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:09:53.806+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:09:53.806+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:09:53.936+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:09:53.946+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 18730
06-13 14:09:53.946+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[18730] terminate event is forwarded
06-13 14:09:53.946+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:09:53.946+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 18730, ]
06-13 14:09:53.946+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:09:53.946+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:09:53.946+0900 I/Tizen::App( 1175): (512) > Not registered pid(18730)
06-13 14:09:53.946+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:09:53.946+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:09:53.946+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18730
06-13 14:09:53.946+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-13 14:09:53.946+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-13 14:09:53.946+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-13 14:09:53.946+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:09:53.946+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:09:53.946+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 18730.
06-13 14:09:53.946+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:09:53.946+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:09:53.946+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:09:53.946+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:09:53.946+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:09:53.956+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:09:53.956+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-13 14:09:53.956+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-13 14:09:53.956+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-13 14:09:53.956+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-13 14:09:53.966+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: PAUSE State: RUNNING
06-13 14:09:53.966+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:09:53.966+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:09:53.966+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:09:53.966+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-13 14:09:53.966+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-13 14:09:53.966+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:09:53.966+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:09:53.966+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:09:53.966+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:09:53.966+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:09:53.966+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(857) status(4)
06-13 14:09:53.966+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(857)
06-13 14:09:53.966+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 857, appid: com.samsung.lockscreen, status: bg
06-13 14:09:53.966+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:09:53.966+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:09:53.966+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:09:53.966+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:09:53.966+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:09:53.976+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:09:53.976+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:09:53.986+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:09:53.996+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:09:53.996+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:09:53.996+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:09:54.006+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:09:54.006+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:54.016+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:54.016+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:09:54.066+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-13 14:09:54.066+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:09:54.066+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:09:54.066+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:09:54.066+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:09:54.066+0900 E/LOCKSCREEN(  857): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-13 14:09:54.797+0900 E/PKGMGR_SERVER(18749): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:09:55.007+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.017+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.027+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.027+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.047+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.047+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.067+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.067+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.087+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.087+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.107+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.107+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.117+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.127+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.137+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.137+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.157+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.157+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.177+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.177+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.197+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.197+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.207+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:09:55.217+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:09:55.558+0900 E/PKGMGR_SERVER(18749): pkgmgr-server.c: sighandler(417) > child NORMAL exit [18753]
06-13 14:09:56.789+0900 E/PKGMGR_SERVER(18749): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:09:56.789+0900 E/PKGMGR_SERVER(18749): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:09:57.630+0900 E/PKGMGR  (18802): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 14:09:57.710+0900 E/PKGMGR_SERVER(18804): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:09:57.770+0900 E/PKGMGR_SERVER(18804): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:09:57.780+0900 E/PKGMGR_INFO(18804): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:09:57.790+0900 E/rpm-installer(18804): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:09:57.790+0900 E/PKGMGR_SERVER(18804): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:09:57.800+0900 E/PKGMGR  (18802): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[188020002]
06-13 14:09:57.920+0900 E/PKGMGR_INSTALLER(18807): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:09:57.920+0900 E/rpm-installer(18807): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:09:57.930+0900 E/rpm-installer(18807): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:09:57.930+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:09:57.930+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:09:57.930+0900 E/rpm-installer(18807): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:09:57.930+0900 E/rpm-installer(18807): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:09:58.030+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:09:58.030+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
06-13 14:09:58.030+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.030+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.040+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:09:58.040+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:09:58.040+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:09:58.040+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.040+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.330+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:09:58.330+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:09:58.330+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:09:58.330+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:09:58.330+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:09:58.330+0900 E/rpm-installer(18807): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:09:58.340+0900 E/PKGMGR_PARSER(18807): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:09:58.340+0900 E/PKGMGR_PARSER(18807): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:09:58.381+0900 I/PRIVACY-MANAGER-CLIENT(18807): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:09:58.591+0900 E/PKGMGR_PARSER(18807): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:09:58.611+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:09:58.621+0900 E/PKGMGR_CERT(18807): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:09:58.621+0900 E/rpm-installer(18807): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:09:58.621+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:09:58.621+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:09:58.621+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
06-13 14:09:58.621+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.621+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.641+0900 E/rpm-installer(18807): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:09:58.661+0900 E/rpm-installer(18807): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:09:58.661+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.661+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:09:58.661+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:09:58.661+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:09:58.661+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
06-13 14:09:58.801+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:09:58.981+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:09:59.792+0900 E/PKGMGR_SERVER(18804): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:10:00.252+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:10:00.262+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:10
06-13 14:10:00.262+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:10"
06-13 14:10:00.262+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:10"
06-13 14:10:00.262+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:10:00.262+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146948618 Time: <font_size=31> </font_size> <font_size=31> 오후 2:10</font_size></font>"
06-13 14:10:00.513+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:10:00.513+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:10:00.513+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:10:00.513+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:10:00.513+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:10:00.513+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:10:00.513+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:10:00.513+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:10:00.523+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:10:00.543+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:10:00.553+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:10:00.553+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:10:00.553+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:10:00.553+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:10:00.553+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:10:00.563+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:10:00.563+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:10:00.563+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
06-13 14:10:00.563+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:10:00.563+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:10:00.563+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:10:00.563+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:10:00.563+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:10:00.573+0900 E/PKGMGR_SERVER(18804): pkgmgr-server.c: sighandler(417) > child NORMAL exit [18807]
06-13 14:10:00.573+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:10:00.573+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:10:00.573+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:10:00.573+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:10:00.583+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:10:00.583+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:10:00.583+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:10:00.583+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:10:00.583+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:10:00.583+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:10:00.603+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:10:00.633+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:10:01.794+0900 E/PKGMGR_SERVER(18804): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:10:01.794+0900 E/PKGMGR_SERVER(18804): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:10:04.857+0900 W/AUL     (18862): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:10:04.857+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:10:04.867+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:10:04.877+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:10:04.877+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:10:04.877+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 18862
06-13 14:10:04.877+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:10:04.877+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:10:04.877+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:10:04.887+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:10:04.887+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:10:04.887+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:10:04.897+0900 I/abc     (18519): abc
06-13 14:10:04.897+0900 I/CAPI_APPFW_APPLICATION(18519): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:10:04.907+0900 I/CAPI_APPFW_APPLICATION(18519): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:10:04.927+0900 E/TBM     (18519): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:10:04.987+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 18519, appid: org.example.client
06-13 14:10:04.987+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:10:04.997+0900 W/AUL     (18862): launch.c: app_request_to_launchpad(425) > request cmd(0) result(18519)
06-13 14:10:05.187+0900 W/CRASH_MANAGER(18876): worker.c: worker_job(1199) > 0618519636c69149733060
