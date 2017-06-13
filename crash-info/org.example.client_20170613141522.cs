S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 20244
Date: 2017-06-13 14:15:22+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 20244, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004f14
r2   = 0x00000006, r3   = 0xb41414c0
r4   = 0x00000002, r5   = 0xb4141000
r6   = 0xb683b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb8ee72a8
r10  = 0xbea84498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbea840dc
lr   = 0xb6731f18, pc   = 0xb6730b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     48504 KB
Buffers:     65980 KB
Cached:     243252 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19636 KB
VmRSS:       19636 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20244 TID = 20244
20244 20250 20270 20272 

Maps Information
b140a000 b1412000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1424000 b1c23000 rw-p [stack:20272]
b1c23000 b1c24000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c34000 b1c48000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c5c000 b1c5d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c6d000 b1c70000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c81000 b1c82000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c92000 b1c94000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1ca4000 b1ca6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cb6000 b1cc6000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cd6000 b1ce2000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cf4000 b24f3000 rw-p [stack:20270]
b2824000 b282b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b283e000 b2844000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2854000 b2884000 r-xp /opt/usr/apps/org.example.client/bin/client
b29cd000 b2ab0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae7000 b2b0f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b21000 b3320000 rw-p [stack:20250]
b3320000 b3322000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3332000 b333c000 r-xp /lib/libnss_files-2.20-2014.11.so
b334d000 b3356000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3367000 b3378000 r-xp /lib/libnsl-2.20-2014.11.so
b338b000 b3391000 r-xp /lib/libnss_compat-2.20-2014.11.so
b33a2000 b33a3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33cb000 b33d2000 r-xp /usr/lib/libminizip.so.1.0.0
b33e2000 b33e7000 r-xp /usr/lib/libstorage.so.0.1
b33f7000 b3456000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b346c000 b3480000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3490000 b34d4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34e4000 b34ec000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34fc000 b352c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b353f000 b35f8000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b360c000 b365f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3670000 b368b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b369b000 b375c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b376f000 b377f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b378f000 b379c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37ad000 b37b4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37c4000 b3805000 r-xp /usr/lib/libmdm.so.1.2.12
b3815000 b381d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b382c000 b383c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b385d000 b38bd000 r-xp /usr/lib/libasound.so.2.0.0
b38cf000 b38d2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38e2000 b38e5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38f5000 b38fa000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b390a000 b390b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b391b000 b3926000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b393a000 b3941000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3951000 b3957000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3967000 b396c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b397c000 b3997000 r-xp /usr/lib/libmmfsound.so.0.1.0
b39a7000 b39ae000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39be000 b39c1000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39d2000 b3a00000 r-xp /usr/lib/libidn.so.11.5.44
b3a10000 b3a26000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a37000 b3a41000 r-xp /usr/lib/libcares.so.2.1.0
b3a51000 b3a5b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a6b000 b3a6d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a7d000 b3a7e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a8e000 b3a92000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3aa3000 b3acb000 r-xp /usr/lib/libui-extension.so.0.1.0
b3adc000 b3b05000 r-xp /usr/lib/libturbojpeg.so
b3b25000 b3b2b000 r-xp /usr/lib/libgif.so.4.1.6
b3b3b000 b3b81000 r-xp /usr/lib/libcurl.so.4.3.0
b3b92000 b3bb3000 r-xp /usr/lib/libexif.so.12.3.3
b3bce000 b3be3000 r-xp /usr/lib/libtts.so
b3bf4000 b3bfc000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c0c000 b3cd2000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cf2000 b3dea000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e09000 b3ed7000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eee000 b3ef0000 r-xp /usr/lib/libboost_system.so.1.51.0
b3f00000 b3f06000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f16000 b3f39000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f4a000 b3f4c000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f5c000 b3f5e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f6f000 b3f74000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f8b000 b3f8d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f9d000 b3fa4000 r-xp /usr/lib/libsensord-share.so
b3fb4000 b3fcc000 r-xp /usr/lib/libsensor.so.1.1.0
b3fdd000 b3fe0000 r-xp /usr/lib/libXv.so.1.0.0
b3ff0000 b3ff5000 r-xp /usr/lib/libutilX.so.1.1.0
b4005000 b400a000 r-xp /usr/lib/libappcore-common.so.1.1
b401a000 b4021000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4034000 b4038000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4049000 b4127000 r-xp /usr/lib/libCOREGL.so.4.0
b4147000 b414a000 r-xp /usr/lib/libuuid.so.1.3.0
b415a000 b4171000 r-xp /usr/lib/libblkid.so.1.1.0
b4182000 b4184000 r-xp /usr/lib/libXau.so.6.0.0
b4194000 b41db000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41ed000 b41f3000 r-xp /usr/lib/libjson-c.so.2.0.1
b4204000 b4208000 r-xp /usr/lib/libogg.so.0.7.1
b4218000 b423a000 r-xp /usr/lib/libvorbis.so.0.4.3
b424a000 b432e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b434a000 b434d000 r-xp /usr/lib/libEGL.so.1.4
b435e000 b4364000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4374000 b4376000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4386000 b4393000 r-xp /usr/lib/libGLESv2.so.2.0
b43a4000 b4406000 r-xp /usr/lib/libpixman-1.so.0.28.2
b441b000 b4433000 r-xp /usr/lib/libmount.so.1.1.0
b4445000 b4459000 r-xp /usr/lib/libxcb.so.1.1.0
b4469000 b4470000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a8000 b44aa000 r-xp /usr/lib/libiri.so
b44ba000 b44c5000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44d6000 b450c000 r-xp /usr/lib/libpulse.so.0.16.2
b451d000 b4560000 r-xp /usr/lib/libsndfile.so.1.0.25
b4575000 b458a000 r-xp /lib/libexpat.so.1.5.2
b459c000 b465a000 r-xp /usr/lib/libcairo.so.2.11200.14
b466e000 b4676000 r-xp /usr/lib/libdrm.so.2.4.0
b4686000 b4689000 r-xp /usr/lib/libdri2.so.0.0.0
b4699000 b46e7000 r-xp /usr/lib/libssl.so.1.0.0
b46fc000 b4708000 r-xp /usr/lib/libeeze.so.1.13.0
b4719000 b4722000 r-xp /usr/lib/libethumb.so.1.13.0
b4732000 b4735000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4745000 b48fc000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e7000 b56f0000 r-xp /usr/lib/libXi.so.6.1.0
b5700000 b5702000 r-xp /usr/lib/libXgesture.so.7.0.0
b5712000 b5716000 r-xp /usr/lib/libXtst.so.6.1.0
b5726000 b572c000 r-xp /usr/lib/libXrender.so.1.3.0
b573c000 b5742000 r-xp /usr/lib/libXrandr.so.2.2.0
b5752000 b5754000 r-xp /usr/lib/libXinerama.so.1.0.0
b5765000 b5768000 r-xp /usr/lib/libXfixes.so.3.1.0
b5778000 b5783000 r-xp /usr/lib/libXext.so.6.4.0
b5793000 b5795000 r-xp /usr/lib/libXdamage.so.1.1.0
b57a5000 b57a7000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b7000 b5899000 r-xp /usr/lib/libX11.so.6.3.0
b58ad000 b58b4000 r-xp /usr/lib/libXcursor.so.1.0.2
b58c4000 b58dc000 r-xp /usr/lib/libudev.so.1.6.0
b58de000 b58e1000 r-xp /lib/libattr.so.1.1.0
b58f1000 b5911000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5912000 b5917000 r-xp /usr/lib/libffi.so.6.0.2
b5928000 b5940000 r-xp /lib/libz.so.1.2.8
b5950000 b5952000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5962000 b5a37000 r-xp /usr/lib/libxml2.so.2.9.2
b5a4c000 b5ae7000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b03000 b5b06000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b16000 b5b2f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b40000 b5b51000 r-xp /lib/libresolv-2.20-2014.11.so
b5b65000 b5bdf000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bf4000 b5bf6000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c06000 b5c0d000 r-xp /usr/lib/libembryo.so.1.13.0
b5c1d000 b5c27000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c38000 b5c50000 r-xp /usr/lib/libpng12.so.0.50.0
b5c61000 b5c84000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ca5000 b5cb9000 r-xp /usr/lib/libector.so.1.13.0
b5cca000 b5ce2000 r-xp /usr/lib/liblua-5.1.so
b5cf3000 b5d4a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d5e000 b5d86000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d97000 b5daa000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dbb000 b5df5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e06000 b5e14000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e24000 b5e2c000 r-xp /usr/lib/libtbm.so.1.0.0
b5e3c000 b5e49000 r-xp /usr/lib/libeio.so.1.13.0
b5e59000 b5e5b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e6b000 b5e70000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e80000 b5e97000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea9000 b5ec9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed9000 b5ef9000 r-xp /usr/lib/libecore_con.so.1.13.0
b5efb000 b5f01000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f11000 b5f22000 r-xp /usr/lib/libemotion.so.1.13.0
b5f33000 b5f3a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f4a000 b5f59000 r-xp /usr/lib/libeo.so.1.13.0
b5f6a000 b5f7c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f8d000 b5f92000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fa2000 b5fbb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fcb000 b5fe8000 r-xp /usr/lib/libeet.so.1.13.0
b6001000 b6049000 r-xp /usr/lib/libeina.so.1.13.0
b605a000 b606a000 r-xp /usr/lib/libefl.so.1.13.0
b607b000 b6160000 r-xp /usr/lib/libicuuc.so.51.1
b617d000 b62bd000 r-xp /usr/lib/libicui18n.so.51.1
b62d4000 b630c000 r-xp /usr/lib/libecore_x.so.1.13.0
b631e000 b6321000 r-xp /lib/libcap.so.2.21
b6331000 b635a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b636b000 b6372000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6384000 b63bb000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63cc000 b64b7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64ca000 b6543000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6555000 b655a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b656a000 b6574000 r-xp /usr/lib/libvconf.so.0.2.45
b6584000 b6586000 r-xp /usr/lib/libvasum.so.0.3.1
b6596000 b6598000 r-xp /usr/lib/libttrace.so.1.1
b65a8000 b65ab000 r-xp /usr/lib/libiniparser.so.0
b65bb000 b65e1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65f1000 b65f6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6607000 b661e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b662f000 b669a000 r-xp /lib/libm-2.20-2014.11.so
b66ab000 b66b1000 r-xp /lib/librt-2.20-2014.11.so
b66c2000 b66cf000 r-xp /usr/lib/libunwind.so.8.0.1
b6705000 b6829000 r-xp /lib/libc-2.20-2014.11.so
b683e000 b6857000 r-xp /lib/libgcc_s-4.9.so.1
b6867000 b6949000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b695a000 b6984000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6995000 b69d1000 r-xp /usr/lib/libsystemd.so.0.4.0
b69d3000 b6a56000 r-xp /usr/lib/libedje.so.1.13.0
b6a69000 b6a87000 r-xp /usr/lib/libecore.so.1.13.0
b6aa7000 b6c2e000 r-xp /usr/lib/libevas.so.1.13.0
b6c63000 b6c77000 r-xp /lib/libpthread-2.20-2014.11.so
b6c8b000 b6ebf000 r-xp /usr/lib/libelementary.so.1.13.0
b6eee000 b6ef2000 r-xp /usr/lib/libsmack.so.1.0.0
b6f02000 b6f09000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f19000 b6f1b000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2b000 b6f2e000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3e000 b6f40000 r-xp /lib/libdl-2.20-2014.11.so
b6f51000 b6f69000 r-xp /usr/lib/libaul.so.0.1.0
b6f7d000 b6f82000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f93000 b6fa0000 r-xp /usr/lib/liblptcp.so
b6fb2000 b6fb6000 r-xp /usr/lib/libsys-assert.so
b6fc7000 b6fe7000 r-xp /lib/ld-2.20-2014.11.so
b6ff8000 b6ffd000 r-xp /usr/bin/launchpad-loader
b8ea6000 b90eb000 rw-p [heap]
bea64000 bea85000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20244)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6730b84) [/lib/libc.so.6] + 0x2bb84
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
:20.715+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:15:20.765+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 20252
06-13 14:15:20.765+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20252, appid: com.samsung.weather-m-agent
06-13 14:15:20.785+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 14:15:20.785+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 20252.
06-13 14:15:20.785+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20252)
06-13 14:15:20.935+0900 E/weather-agent(20252): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 14:15:20.935+0900 E/weather-common(20252): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 14:15:20.935+0900 E/weather-agent(20252): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 14:15:20.945+0900 E/weather-common(20252): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 14:15:20.945+0900 E/weather-common(20252): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 14:15:20.945+0900 E/weather-common(20252): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 14:15:20.945+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 14:15:20.945+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 14:15:20.945+0900 I/MESSAGE_PORT(20252): message-port.c: __initialize(872) > initialize
06-13 14:15:20.955+0900 I/MESSAGE_PORT(20252): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-13 14:15:20.975+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:15:20.975+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:15:20.975+0900 I/MESSAGE_PORT(20252): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:15:20.975+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-13 14:15:20.975+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-13 14:15:20.975+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:15:20.985+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-13 14:15:20.985+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:15:20.985+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:15:20.985+0900 E/MESSAGE_PORT(20252): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 14:15:20.985+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:15:20.985+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:15:20.995+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:15:20.995+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:15:20.995+0900 E/MESSAGE_PORT(20252): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:15:20.995+0900 E/weather-common(20252): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:15:20.995+0900 E/weather-agent(20252): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:15:20.995+0900 E/weather-agent(20252): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:15:20.995+0900 I/MESSAGE_PORT(20252): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:15:21.015+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:15:21.045+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:15:21.045+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:15:21.045+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:15:21.045+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:15:21.045+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:15:21.055+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:15:21.065+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:15:21.075+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17907281
06-13 14:15:21.115+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:15:21.115+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:15:21.145+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:15:21.145+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:15:21.145+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:21.155+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-13 14:15:21.165+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:15:21.165+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:15:21.165+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:15:21.175+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:21.175+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:21.296+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17907502
06-13 14:15:21.296+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-13 14:15:21.296+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-13 14:15:21.296+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:15:21.626+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-13 14:15:21.626+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-13 14:15:21.626+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-13 14:15:21.626+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:15:21.626+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:15:21.626+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:15:21.626+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:15:21.626+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:15:21.626+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:15:21.636+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:15:21.636+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:15:21.636+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:15:21.636+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:15:21.636+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(857) status(4)
06-13 14:15:21.636+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(857)
06-13 14:15:21.636+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 857, appid: com.samsung.lockscreen, status: bg
06-13 14:15:21.646+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:15:21.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:15:21.656+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:15:21.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:15:21.656+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:15:21.656+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:15:21.676+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:15:21.676+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:15:21.676+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:15:21.676+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-13 14:15:21.676+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-13 14:15:21.676+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-13 14:15:21.686+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-13 14:15:21.686+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: PAUSE State: RUNNING
06-13 14:15:21.686+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:15:21.686+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:15:21.686+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:15:21.686+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-13 14:15:21.686+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-13 14:15:21.686+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:15:21.686+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:15:21.706+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:15:21.706+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:15:21.786+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-13 14:15:21.786+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:15:21.786+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:15:21.786+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:15:21.786+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:15:21.796+0900 E/LOCKSCREEN(  857): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-13 14:15:21.996+0900 E/weather-agent(20252): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:15:21.996+0900 I/CAPI_APPFW_APPLICATION(20252): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:15:22.006+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:15:22.006+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:15:22.006+0900 E/weather-agent(20252): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:15:22.136+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:15:22.136+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20252
06-13 14:15:22.136+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[20252] terminate event is forwarded
06-13 14:15:22.136+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:15:22.136+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 20252, ]
06-13 14:15:22.136+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:15:22.136+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:15:22.136+0900 I/Tizen::App( 1175): (512) > Not registered pid(20252)
06-13 14:15:22.136+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:15:22.136+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:15:22.136+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20252
06-13 14:15:22.136+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:15:22.136+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 20252.
06-13 14:15:22.176+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.176+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.196+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.196+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.216+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17908419
06-13 14:15:22.216+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.226+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.236+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.236+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.256+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.256+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.277+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.277+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.287+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17908496
06-13 14:15:22.297+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:15:22.297+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:15:22.297+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:15:22.317+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:15:22.317+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:15:22.317+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:15:22.317+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:15:22.317+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:15:22.337+0900 I/abc     (20244): abc
06-13 14:15:22.337+0900 I/CAPI_APPFW_APPLICATION(20244): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:15:22.337+0900 I/CAPI_APPFW_APPLICATION(20244): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:15:22.367+0900 E/TBM     (20244): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:15:22.417+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20244, appid: org.example.client
06-13 14:15:22.417+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:15:22.437+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(20244)
06-13 14:15:22.437+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.437+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.437+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.447+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.447+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.457+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.457+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.467+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.477+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.477+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.477+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.497+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:22.497+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:22.497+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:23.057+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17909262
06-13 14:15:23.057+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17909262
06-13 14:15:23.057+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:15:23.057+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:15:23.057+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:15:23.358+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:15:23.358+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:15:23.358+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:15:23.358+0900 E/STARTER (  721): )
06-13 14:15:23.358+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:15:23.358+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:15:23.358+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:15:23.368+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:15:23.368+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:15:23.378+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:15:23.378+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:15:23.378+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:15:23.378+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:15:23.388+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:15:23.398+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:15:23.448+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20244 pgid = 20244
06-13 14:15:23.448+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(20244)
06-13 14:15:23.448+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 20244.
06-13 14:15:23.448+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1987
06-13 14:15:23.478+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:15:23.478+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:15:23.478+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:15:23.478+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:15:23.478+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:15:23.488+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20244
06-13 14:15:23.488+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 20244.
06-13 14:15:23.488+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1988
06-13 14:15:23.498+0900 E/CAPI_APPFW_APPLICATION(19955): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:15:23.498+0900 E/CAPI_APPFW_APPLICATION(19955): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:15:23.498+0900 E/CAPI_APPFW_APPLICATION(19955): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:15:23.498+0900 E/CAPI_APPFW_APPLICATION(19955): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:15:23.498+0900 E/CAPI_APPFW_APPLICATION(19955): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:15:23.498+0900 I/CAPI_APPFW_APPLICATION(19955): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:15:23.498+0900 I/CAPI_APPFW_APPLICATION(19955): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:15:23.568+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19955, appid: com.samsung.task-mgr
06-13 14:15:23.568+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:15:23.578+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:15:23.588+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19955)
06-13 14:15:23.588+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20244
06-13 14:15:23.588+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20244
06-13 14:15:23.628+0900 W/TASK_MGR_LITE(19955): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:15:23.648+0900 I/GXT_SIB (19955): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:15:23.668+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:15:23.668+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:15:23.718+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:15:23.728+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:15:23.728+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:15:23.728+0900 E/RUA     (19955): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:15:23.728+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:15:23.728+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:15:23.738+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:15:23.738+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:15:23.748+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:15:23.808+0900 I/APP_CORE(19955): appcore-efl.c: __do_app(514) > [APP 19955] Event: RESET State: CREATED
06-13 14:15:23.808+0900 I/CAPI_APPFW_APPLICATION(19955): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:15:23.808+0900 E/EFL     (19955): edje<19955> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:15:23.808+0900 E/EFL     (19955): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:15:23.808+0900 E/EFL     (19955): edje<19955> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:15:23.808+0900 E/EFL     (19955): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:15:23.818+0900 W/APP_CORE(19955): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3a00003
06-13 14:15:23.818+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:15:23.948+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:15:23.948+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:15:23.948+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:15:23.958+0900 I/APP_CORE(19955): appcore-efl.c: __do_app(514) > [APP 19955] Event: RESUME State: CREATED
06-13 14:15:23.958+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:15:23.958+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:15:23.958+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:15:23.968+0900 I/APP_CORE(19955): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:15:23.968+0900 I/APP_CORE(19955): appcore-efl.c: __do_app(625) > [APP 19955] Initial Launching, call the resume_cb
06-13 14:15:23.968+0900 I/CAPI_APPFW_APPLICATION(19955): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:15:24.008+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:15:24.008+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:15:24.008+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:15:24.008+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19955) status(3)
06-13 14:15:24.008+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:15:24.008+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:15:24.008+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(19955)
06-13 14:15:24.008+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19955, appid: com.samsung.task-mgr, status: fg
06-13 14:15:24.008+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17910226
06-13 14:15:24.008+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17910226
06-13 14:15:24.008+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:15:24.008+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:15:24.018+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:15:24.018+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:15:24.018+0900 E/STARTER (  721): )
06-13 14:15:24.018+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:15:24.018+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:15:24.018+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:15:24.018+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:15:24.308+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19955) status(0)
06-13 14:15:24.469+0900 I/UXT     (20283): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:15:24.579+0900 E/EFL     (19955): ecore_x<19955> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17910792
06-13 14:15:24.619+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:15:24.629+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 19955.
06-13 14:15:24.629+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1992
06-13 14:15:24.709+0900 E/EFL     (19955): ecore_x<19955> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17910925
06-13 14:15:24.829+0900 E/EFL     (19955): ecore_x<19955> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17911047
06-13 14:15:24.929+0900 E/EFL     (19955): ecore_x<19955> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17911136
06-13 14:15:25.019+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:15:25.019+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:15:25.019+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(19955)
06-13 14:15:25.019+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19955, appid: com.samsung.task-mgr, status: bg
06-13 14:15:25.029+0900 I/CAPI_APPFW_APPLICATION(19955): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:15:25.029+0900 W/TASK_MGR_LITE(19955): task-mgr-lite.c: _pause_app(406) > 
06-13 14:15:25.029+0900 I/CAPI_APPFW_APPLICATION(19955): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:15:25.029+0900 E/TASK_MGR_LITE(19955): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:15:25.049+0900 E/TASK_MGR_LITE(19955): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:15:25.049+0900 E/APP_CORE(19955): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:15:25.059+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:15:25.059+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:15:25.059+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:15:25.059+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:15:25.059+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:15:25.059+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:15:25.099+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:15:25.109+0900 I/MALI    (19955): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=19955   close drm_fd=30 
06-13 14:15:25.139+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:15:25.139+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:15:25.139+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:15:25.139+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:15:25.199+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:15:25.199+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:15:25.209+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:15:25.229+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:15:25.229+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:15:25.229+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:15:25.239+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:15:25.249+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:15:25.339+0900 W/CRASH_MANAGER(20233): worker.c: worker_job(1199) > 0620244636c69149733092
