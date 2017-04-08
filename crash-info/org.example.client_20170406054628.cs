S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 15374
Date: 2017-04-06 05:46:28+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 15374, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003c0e
r2   = 0x00000006, r3   = 0xb412f4c0
r4   = 0x00000002, r5   = 0xb412f000
r6   = 0xb682909c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f57708
r10  = 0xb75ff870, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe9fbc2c
lr   = 0xb671ff18, pc   = 0xb671eb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     75296 KB
Buffers:     64848 KB
Cached:     284588 KB
VmPeak:     133908 KB
VmSize:     133904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28328 KB
VmRSS:       28328 KB
VmData:      45844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 15374 TID = 15374
15374 15383 15407 15408 15440 

Maps Information
af22e000 afa2d000 rw-p [stack:15440]
b0fd4000 b0fe5000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0ff5000 b0ffa000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13fc000 b1404000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1416000 b1c15000 rw-p [stack:15408]
b1c15000 b1c16000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c26000 b1c3a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c4e000 b1c4f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c5f000 b1c62000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c73000 b1c74000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c84000 b1c86000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c96000 b1c98000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ca8000 b1cb8000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cc8000 b1cd4000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ce6000 b24e5000 rw-p [stack:15407]
b2816000 b281d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2830000 b2836000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2846000 b2862000 r-xp /opt/usr/apps/org.example.client/bin/client
b29bb000 b2a9e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ad5000 b2afd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b0f000 b330e000 rw-p [stack:15383]
b330e000 b3310000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3320000 b332a000 r-xp /lib/libnss_files-2.20-2014.11.so
b333b000 b3344000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3355000 b3366000 r-xp /lib/libnsl-2.20-2014.11.so
b3379000 b337f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3390000 b3391000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33b9000 b33c0000 r-xp /usr/lib/libminizip.so.1.0.0
b33d0000 b33d5000 r-xp /usr/lib/libstorage.so.0.1
b33e5000 b3444000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b345a000 b346e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b347e000 b34c2000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34d2000 b34da000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ea000 b351a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b352d000 b35e6000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35fa000 b364d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b365e000 b3679000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3689000 b374a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b375d000 b376d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b377d000 b378a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b379b000 b37a2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37b2000 b37f3000 r-xp /usr/lib/libmdm.so.1.2.12
b3803000 b380b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b381a000 b382a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b384b000 b38ab000 r-xp /usr/lib/libasound.so.2.0.0
b38bd000 b38c0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38d0000 b38d3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38e3000 b38e8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38f8000 b38f9000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3909000 b3914000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3928000 b392f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b393f000 b3945000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3955000 b395a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b396a000 b3985000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3995000 b399c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39ac000 b39af000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39c0000 b39ee000 r-xp /usr/lib/libidn.so.11.5.44
b39fe000 b3a14000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a25000 b3a2f000 r-xp /usr/lib/libcares.so.2.1.0
b3a3f000 b3a49000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a59000 b3a5b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a6b000 b3a6c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a7c000 b3a80000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a91000 b3ab9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aca000 b3af3000 r-xp /usr/lib/libturbojpeg.so
b3b13000 b3b19000 r-xp /usr/lib/libgif.so.4.1.6
b3b29000 b3b6f000 r-xp /usr/lib/libcurl.so.4.3.0
b3b80000 b3ba1000 r-xp /usr/lib/libexif.so.12.3.3
b3bbc000 b3bd1000 r-xp /usr/lib/libtts.so
b3be2000 b3bea000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bfa000 b3cc0000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ce0000 b3dd8000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df7000 b3ec5000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3edc000 b3ede000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eee000 b3ef4000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f04000 b3f27000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f38000 b3f3a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f4a000 b3f4c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5d000 b3f62000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f79000 b3f7b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f8b000 b3f92000 r-xp /usr/lib/libsensord-share.so
b3fa2000 b3fba000 r-xp /usr/lib/libsensor.so.1.1.0
b3fcb000 b3fce000 r-xp /usr/lib/libXv.so.1.0.0
b3fde000 b3fe3000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff3000 b3ff8000 r-xp /usr/lib/libappcore-common.so.1.1
b4008000 b400f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4022000 b4026000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4037000 b4115000 r-xp /usr/lib/libCOREGL.so.4.0
b4135000 b4138000 r-xp /usr/lib/libuuid.so.1.3.0
b4148000 b415f000 r-xp /usr/lib/libblkid.so.1.1.0
b4170000 b4172000 r-xp /usr/lib/libXau.so.6.0.0
b4182000 b41c9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41db000 b41e1000 r-xp /usr/lib/libjson-c.so.2.0.1
b41f2000 b41f6000 r-xp /usr/lib/libogg.so.0.7.1
b4206000 b4228000 r-xp /usr/lib/libvorbis.so.0.4.3
b4238000 b431c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4338000 b433b000 r-xp /usr/lib/libEGL.so.1.4
b434c000 b4352000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4362000 b4364000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4374000 b4381000 r-xp /usr/lib/libGLESv2.so.2.0
b4392000 b43f4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4409000 b4421000 r-xp /usr/lib/libmount.so.1.1.0
b4433000 b4447000 r-xp /usr/lib/libxcb.so.1.1.0
b4457000 b445e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4496000 b4498000 r-xp /usr/lib/libiri.so
b44a8000 b44b3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c4000 b44fa000 r-xp /usr/lib/libpulse.so.0.16.2
b450b000 b454e000 r-xp /usr/lib/libsndfile.so.1.0.25
b4563000 b4578000 r-xp /lib/libexpat.so.1.5.2
b458a000 b4648000 r-xp /usr/lib/libcairo.so.2.11200.14
b465c000 b4664000 r-xp /usr/lib/libdrm.so.2.4.0
b4674000 b4677000 r-xp /usr/lib/libdri2.so.0.0.0
b4687000 b46d5000 r-xp /usr/lib/libssl.so.1.0.0
b46ea000 b46f6000 r-xp /usr/lib/libeeze.so.1.13.0
b4707000 b4710000 r-xp /usr/lib/libethumb.so.1.13.0
b4720000 b4723000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4733000 b48ea000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d5000 b56de000 r-xp /usr/lib/libXi.so.6.1.0
b56ee000 b56f0000 r-xp /usr/lib/libXgesture.so.7.0.0
b5700000 b5704000 r-xp /usr/lib/libXtst.so.6.1.0
b5714000 b571a000 r-xp /usr/lib/libXrender.so.1.3.0
b572a000 b5730000 r-xp /usr/lib/libXrandr.so.2.2.0
b5740000 b5742000 r-xp /usr/lib/libXinerama.so.1.0.0
b5753000 b5756000 r-xp /usr/lib/libXfixes.so.3.1.0
b5766000 b5771000 r-xp /usr/lib/libXext.so.6.4.0
b5781000 b5783000 r-xp /usr/lib/libXdamage.so.1.1.0
b5793000 b5795000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a5000 b5887000 r-xp /usr/lib/libX11.so.6.3.0
b589b000 b58a2000 r-xp /usr/lib/libXcursor.so.1.0.2
b58b2000 b58ca000 r-xp /usr/lib/libudev.so.1.6.0
b58cc000 b58cf000 r-xp /lib/libattr.so.1.1.0
b58df000 b58ff000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5900000 b5905000 r-xp /usr/lib/libffi.so.6.0.2
b5916000 b592e000 r-xp /lib/libz.so.1.2.8
b593e000 b5940000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5950000 b5a25000 r-xp /usr/lib/libxml2.so.2.9.2
b5a3a000 b5ad5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5af1000 b5af4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b04000 b5b1d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b2e000 b5b3f000 r-xp /lib/libresolv-2.20-2014.11.so
b5b53000 b5bcd000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5be2000 b5be4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf4000 b5bfb000 r-xp /usr/lib/libembryo.so.1.13.0
b5c0b000 b5c15000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c26000 b5c3e000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4f000 b5c72000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c93000 b5ca7000 r-xp /usr/lib/libector.so.1.13.0
b5cb8000 b5cd0000 r-xp /usr/lib/liblua-5.1.so
b5ce1000 b5d38000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4c000 b5d74000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d85000 b5d98000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da9000 b5de3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df4000 b5e02000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e12000 b5e1a000 r-xp /usr/lib/libtbm.so.1.0.0
b5e2a000 b5e37000 r-xp /usr/lib/libeio.so.1.13.0
b5e47000 b5e49000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e59000 b5e5e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6e000 b5e85000 r-xp /usr/lib/libefreet.so.1.13.0
b5e97000 b5eb7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec7000 b5ee7000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee9000 b5eef000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eff000 b5f10000 r-xp /usr/lib/libemotion.so.1.13.0
b5f21000 b5f28000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f38000 b5f47000 r-xp /usr/lib/libeo.so.1.13.0
b5f58000 b5f6a000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7b000 b5f80000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f90000 b5fa9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb9000 b5fd6000 r-xp /usr/lib/libeet.so.1.13.0
b5fef000 b6037000 r-xp /usr/lib/libeina.so.1.13.0
b6048000 b6058000 r-xp /usr/lib/libefl.so.1.13.0
b6069000 b614e000 r-xp /usr/lib/libicuuc.so.51.1
b616b000 b62ab000 r-xp /usr/lib/libicui18n.so.51.1
b62c2000 b62fa000 r-xp /usr/lib/libecore_x.so.1.13.0
b630c000 b630f000 r-xp /lib/libcap.so.2.21
b631f000 b6348000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6359000 b6360000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6372000 b63a9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63ba000 b64a5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b8000 b6531000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6543000 b6548000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6558000 b6562000 r-xp /usr/lib/libvconf.so.0.2.45
b6572000 b6574000 r-xp /usr/lib/libvasum.so.0.3.1
b6584000 b6586000 r-xp /usr/lib/libttrace.so.1.1
b6596000 b6599000 r-xp /usr/lib/libiniparser.so.0
b65a9000 b65cf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65df000 b65e4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f5000 b660c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661d000 b6688000 r-xp /lib/libm-2.20-2014.11.so
b6699000 b669f000 r-xp /lib/librt-2.20-2014.11.so
b66b0000 b66bd000 r-xp /usr/lib/libunwind.so.8.0.1
b66f3000 b6817000 r-xp /lib/libc-2.20-2014.11.so
b682c000 b6845000 r-xp /lib/libgcc_s-4.9.so.1
b6855000 b6937000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6948000 b6972000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6983000 b69bf000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c1000 b6a44000 r-xp /usr/lib/libedje.so.1.13.0
b6a57000 b6a75000 r-xp /usr/lib/libecore.so.1.13.0
b6a95000 b6c1c000 r-xp /usr/lib/libevas.so.1.13.0
b6c51000 b6c65000 r-xp /lib/libpthread-2.20-2014.11.so
b6c79000 b6ead000 r-xp /usr/lib/libelementary.so.1.13.0
b6edc000 b6ee0000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef0000 b6ef7000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f07000 b6f09000 r-xp /usr/lib/libdlog.so.0.0.0
b6f19000 b6f1c000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2c000 b6f2e000 r-xp /lib/libdl-2.20-2014.11.so
b6f3f000 b6f57000 r-xp /usr/lib/libaul.so.0.1.0
b6f6b000 b6f70000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f81000 b6f8e000 r-xp /usr/lib/liblptcp.so
b6fa0000 b6fa4000 r-xp /usr/lib/libsys-assert.so
b6fb5000 b6fd5000 r-xp /lib/ld-2.20-2014.11.so
b6fe6000 b6feb000 r-xp /usr/bin/launchpad-loader
b727c000 b765b000 rw-p [heap]
be9dc000 be9fd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15374)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb671eb84) [/lib/libc.so.6] + 0x2bb84
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
grab key(XF86Back)
04-06 05:46:18.491+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:18.491+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:46:18.491+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:46:18.491+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:46:18.511+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:18.511+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:18.511+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:46:18.511+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 15237
04-06 05:46:18.511+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[15237] terminate event is forwarded
04-06 05:46:18.511+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:18.511+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 15237, ]
04-06 05:46:18.511+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:18.511+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:46:18.511+0900 I/Tizen::App( 1231): (512) > Not registered pid(15237)
04-06 05:46:18.511+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:46:18.511+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:18.511+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15237
04-06 05:46:18.511+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15237
04-06 05:46:18.521+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:46:18.521+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:18.521+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:46:18.521+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:18.521+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2364
04-06 05:46:18.541+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:46:18.561+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:18.561+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 15237.
04-06 05:46:18.581+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:46:18.591+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:46:18.591+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:18.591+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:18.611+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:46:18.611+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:18.611+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:46:18.611+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:18.621+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:18.621+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:46:18.641+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7923f58]
04-06 05:46:18.641+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:46:18.641+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7923f58
04-06 05:46:18.651+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:46:18.651+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:46:18.651+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:46:18.651+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:46:18.651+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:46:20.402+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223099766
04-06 05:46:20.483+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223099843
04-06 05:46:20.483+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:46:20.483+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:46:20.483+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 05:46:20.493+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:46:20.493+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:20.503+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:20.503+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:20.503+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:20.513+0900 I/abc     (15318): abc
04-06 05:46:20.513+0900 I/CAPI_APPFW_APPLICATION(15318): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:20.513+0900 I/CAPI_APPFW_APPLICATION(15318): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:20.543+0900 E/TBM     (15318): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:20.603+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15318, appid: org.example.client
04-06 05:46:20.603+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:20.613+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(15318)
04-06 05:46:20.803+0900 D/basicui (15318): successed to load edc file
04-06 05:46:20.843+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:20.843+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:20.873+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:46:20.873+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:20.873+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:20.873+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:20.913+0900 I/MY_LOG  (15318): change
04-06 05:46:20.963+0900 I/APP_CORE(15318): appcore-efl.c: __do_app(514) > [APP 15318] Event: RESET State: CREATED
04-06 05:46:20.963+0900 I/CAPI_APPFW_APPLICATION(15318): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:20.973+0900 E/EFL     (15318): edje<15318> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:20.973+0900 E/EFL     (15318): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:20.973+0900 E/EFL     (15318): edje<15318> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:20.973+0900 E/EFL     (15318): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:20.973+0900 E/EFL     (15318): edje<15318> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:20.973+0900 E/EFL     (15318): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:20.983+0900 W/APP_CORE(15318): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 05:46:20.983+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:21.103+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:46:21.103+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:21.103+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:46:21.103+0900 I/APP_CORE(15318): appcore-efl.c: __do_app(514) > [APP 15318] Event: RESUME State: CREATED
04-06 05:46:21.103+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:46:21.103+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:46:21.103+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:46:21.113+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15318) status(3)
04-06 05:46:21.113+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(15318)
04-06 05:46:21.113+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15318, appid: org.example.client, status: fg
04-06 05:46:21.123+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:46:21.123+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:46:21.123+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:46:21.123+0900 I/APP_CORE(15318): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:21.123+0900 I/APP_CORE(15318): appcore-efl.c: __do_app(625) > [APP 15318] Initial Launching, call the resume_cb
04-06 05:46:21.123+0900 I/CAPI_APPFW_APPLICATION(15318): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:21.443+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15318) status(0)
04-06 05:46:21.464+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=223100829
04-06 05:46:21.464+0900 W/STARTER (  709): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
04-06 05:46:21.464+0900 W/STARTER (  709): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
04-06 05:46:21.464+0900 E/EFL     (15318): ecore_x<15318> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=223100829
04-06 05:46:21.624+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2365
04-06 05:46:21.624+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:46:21.624+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 15318.
04-06 05:46:21.764+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 05:46:21.764+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 05:46:21.764+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 05:46:21.764+0900 E/STARTER (  709): )
04-06 05:46:21.764+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 05:46:21.764+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 05:46:21.764+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 05:46:21.774+0900 W/AUL     (  709): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
04-06 05:46:21.774+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:46:21.784+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-06 05:46:21.784+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:46:21.784+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 709
04-06 05:46:21.784+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:46:21.794+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:21.804+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:21.804+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:21.804+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:21.824+0900 I/GXT_SIB (  351): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 05:46:21.824+0900 E/CAPI_APPFW_APPLICATION(12007): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:46:21.824+0900 E/CAPI_APPFW_APPLICATION(12007): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:46:21.824+0900 E/CAPI_APPFW_APPLICATION(12007): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:46:21.824+0900 E/CAPI_APPFW_APPLICATION(12007): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:46:21.824+0900 E/CAPI_APPFW_APPLICATION(12007): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:46:21.824+0900 I/CAPI_APPFW_APPLICATION(12007): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:21.824+0900 I/CAPI_APPFW_APPLICATION(12007): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:21.834+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6c466e9 in class 'Edje_Object'.
04-06 05:46:21.834+0900 E/UXT     (  351): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
04-06 05:46:21.904+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 12007, appid: com.samsung.task-mgr
04-06 05:46:21.904+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:21.904+0900 W/AUL     (  709): launch.c: app_request_to_launchpad(425) > request cmd(0) result(12007)
04-06 05:46:21.904+0900 E/RESOURCED(  664): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
04-06 05:46:21.944+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:21.964+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:21.974+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:21.994+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.014+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.024+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.044+0900 W/TASK_MGR_LITE(12007): task-mgr-lite.c: create_win(197) > changeable ui enabled success
04-06 05:46:22.044+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.044+0900 I/GXT_SIB (12007): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 05:46:22.094+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:22.094+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:22.114+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.124+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 05:46:22.124+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.134+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:46:22.134+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:22.134+0900 E/RUA     (12007): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
04-06 05:46:22.144+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:46:22.144+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 15318
04-06 05:46:22.144+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.144+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-06 05:46:22.144+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-06 05:46:22.154+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.154+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:22.154+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:46:22.154+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:22.164+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.164+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:46:22.164+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:22.164+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:22.204+0900 E/EFL     (15318): ecore_x<15318> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=223101578
04-06 05:46:22.204+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=223101578
04-06 05:46:22.204+0900 W/STARTER (  709): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-06 05:46:22.214+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 05:46:22.214+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 05:46:22.214+0900 E/STARTER (  709): )
04-06 05:46:22.214+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 05:46:22.214+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 05:46:22.214+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 05:46:22.214+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 05:46:22.224+0900 I/APP_CORE(12007): appcore-efl.c: __do_app(514) > [APP 12007] Event: RESET State: CREATED
04-06 05:46:22.224+0900 I/CAPI_APPFW_APPLICATION(12007): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:22.224+0900 E/EFL     (12007): edje<12007> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:22.224+0900 E/EFL     (12007): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:22.234+0900 E/EFL     (12007): edje<12007> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:22.234+0900 E/EFL     (12007): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:22.234+0900 W/APP_CORE(12007): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
04-06 05:46:22.234+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:22.364+0900 I/APP_CORE(15318): appcore-efl.c: __do_app(514) > [APP 15318] Event: PAUSE State: RUNNING
04-06 05:46:22.364+0900 I/CAPI_APPFW_APPLICATION(15318): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:22.364+0900 I/APP_CORE(12007): appcore-efl.c: __do_app(514) > [APP 12007] Event: RESUME State: CREATED
04-06 05:46:22.374+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:46:22.384+0900 I/TIZEN_N_EFL_UTIL_WINDOW(15318): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 19
04-06 05:46:22.384+0900 E/APP_CORE(15318): appcore-efl.c: _capture_and_make_file(1619) > win[6400002] widget[720] height[1280]
04-06 05:46:22.384+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:46:22.384+0900 I/APP_CORE(12007): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:22.384+0900 I/APP_CORE(12007): appcore-efl.c: __do_app(625) > [APP 12007] Initial Launching, call the resume_cb
04-06 05:46:22.384+0900 I/CAPI_APPFW_APPLICATION(12007): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:22.394+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(12007) status(0)
04-06 05:46:22.394+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(12007) status(0)
04-06 05:46:22.404+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15318) status(4)
04-06 05:46:22.404+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(15318)
04-06 05:46:22.404+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15318, appid: org.example.client, status: bg
04-06 05:46:22.404+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(12007) status(3)
04-06 05:46:22.404+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:22.404+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:22.404+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(12007)
04-06 05:46:22.404+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 12007, appid: com.samsung.task-mgr, status: fg
04-06 05:46:22.695+0900 I/UXT     (15374): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:46:22.765+0900 E/EFL     (12007): ecore_x<12007> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223102136
04-06 05:46:22.925+0900 E/EFL     (12007): ecore_x<12007> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223102290
04-06 05:46:22.945+0900 I/Tizen::App( 1231): (499) > LaunchedApp(com.samsung.task-mgr)
04-06 05:46:22.945+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for com.samsung.task-mgr, 12007.
04-06 05:46:23.335+0900 E/EFL     (12007): ecore_x<12007> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223102704
04-06 05:46:23.445+0900 E/EFL     (12007): ecore_x<12007> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223102814
04-06 05:46:23.766+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:46:23.766+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:46:23.766+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(12007)
04-06 05:46:23.766+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 12007, appid: com.samsung.task-mgr, status: bg
04-06 05:46:23.766+0900 I/CAPI_APPFW_APPLICATION(12007): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:23.766+0900 W/TASK_MGR_LITE(12007): task-mgr-lite.c: _pause_app(406) > 
04-06 05:46:23.766+0900 I/CAPI_APPFW_APPLICATION(12007): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:46:23.766+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:46:23.766+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 15318
04-06 05:46:23.766+0900 W/AUL     (12007): launch.c: app_request_to_launchpad(396) > request cmd(4) to(15318)
04-06 05:46:23.766+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 4
04-06 05:46:23.766+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(15318), cmd(4)
04-06 05:46:23.766+0900 W/AUL     (12007): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-06 05:46:23.776+0900 I/APP_CORE(15318): appcore-efl.c: __do_app(514) > [APP 15318] Event: TERMINATE State: PAUSED
04-06 05:46:23.776+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:46:23.776+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:46:23.776+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:46:23.776+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:46:23.786+0900 I/TIZEN_N_EFL_UTIL_WINDOW(15318): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 13
04-06 05:46:23.786+0900 E/APP_CORE(15318): appcore-efl.c: _capture_and_make_file(1619) > win[6400002] widget[720] height[1280]
04-06 05:46:23.786+0900 E/TASK_MGR_LITE(12007): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-06 05:46:23.786+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:46:23.786+0900 E/APP_CORE(15318): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 05:46:23.796+0900 I/CAPI_APPFW_APPLICATION(15318): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:46:23.806+0900 E/TASK_MGR_LITE(12007): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
04-06 05:46:23.816+0900 E/APP_CORE(12007): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-06 05:46:23.816+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:23.826+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:46:23.826+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:23.826+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:23.826+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:46:23.826+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:46:23.856+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:46:23.856+0900 I/MALI    (12007): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=12007   close drm_fd=30 
04-06 05:46:23.906+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:23.906+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:46:23.906+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:23.906+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:46:23.916+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:23.926+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:46:23.936+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-06 05:46:23.936+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-06 05:46:23.946+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:46:23.956+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:46:23.976+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b6c480]
04-06 05:46:23.986+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:46:23.986+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b6c480
04-06 05:46:23.996+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:46:24.006+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:46:24.006+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:46:24.006+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:46:24.006+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:46:24.016+0900 I/UXT     (15385): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:46:24.196+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15318 pgid = 15318
04-06 05:46:24.196+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(15318)
04-06 05:46:24.226+0900 E/TBM     (15385): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:24.226+0900 I/MALI    (15385): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=15385   open drm_fd=29 
04-06 05:46:24.256+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:24.256+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(12007)
04-06 05:46:24.256+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[15318] terminate event is forwarded
04-06 05:46:24.256+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:24.256+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 15318, ]
04-06 05:46:24.256+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:24.256+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:46:24.256+0900 I/Tizen::App( 1231): (512) > Not registered pid(15318)
04-06 05:46:24.256+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:46:24.256+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:24.256+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 15318
04-06 05:46:24.266+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15318
04-06 05:46:24.266+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2372
04-06 05:46:24.296+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:24.296+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 15318.
04-06 05:46:24.336+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:24.336+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:24.336+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 12007 pgid = -1
04-06 05:46:24.336+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:24.336+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:46:24.346+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 12007
04-06 05:46:24.346+0900 I/Tizen::App( 1231): (243) > App[com.samsung.task-mgr] pid[12007] terminate event is forwarded
04-06 05:46:24.346+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:24.346+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.task-mgr, 12007, ]
04-06 05:46:24.346+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:24.346+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.task-mgr)
04-06 05:46:24.346+0900 I/Tizen::App( 1231): (512) > Not registered pid(12007)
04-06 05:46:24.346+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.task-mgr]
04-06 05:46:24.346+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:24.356+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 12007
04-06 05:46:24.356+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 12007
04-06 05:46:24.366+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2373
04-06 05:46:24.396+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:24.396+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.task-mgr, 12007.
04-06 05:46:24.506+0900 E/EFL     (15385): edje<15385> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:24.506+0900 E/EFL     (15385): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:24.506+0900 E/EFL     (15385): edje<15385> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:24.506+0900 E/EFL     (15385): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:24.506+0900 E/EFL     (15385): edje<15385> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:24.506+0900 E/EFL     (15385): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:24.957+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223104324
04-06 05:46:25.007+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223104379
04-06 05:46:25.017+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:46:25.017+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:46:25.017+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 05:46:25.027+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:46:25.027+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:25.027+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:25.027+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:25.027+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:25.047+0900 I/abc     (15374): abc
04-06 05:46:25.047+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:25.047+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:25.077+0900 E/TBM     (15374): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:25.127+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15374, appid: org.example.client
04-06 05:46:25.127+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:25.137+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(15374)
04-06 05:46:25.337+0900 D/basicui (15374): successed to load edc file
04-06 05:46:25.377+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:25.377+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:25.407+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:46:25.407+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:25.407+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:25.407+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:25.437+0900 I/MY_LOG  (15374): change
04-06 05:46:25.487+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(514) > [APP 15374] Event: RESET State: CREATED
04-06 05:46:25.487+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:25.497+0900 E/EFL     (15374): edje<15374> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:25.497+0900 E/EFL     (15374): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:25.507+0900 E/EFL     (15374): edje<15374> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:25.507+0900 E/EFL     (15374): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:25.507+0900 E/EFL     (15374): edje<15374> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:25.507+0900 E/EFL     (15374): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:25.517+0900 W/APP_CORE(15374): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-06 05:46:25.517+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:25.628+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:46:25.628+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:25.628+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:46:25.628+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(514) > [APP 15374] Event: RESUME State: CREATED
04-06 05:46:25.638+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:46:25.638+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:46:25.638+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:46:25.638+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15374) status(3)
04-06 05:46:25.648+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(15374)
04-06 05:46:25.648+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15374, appid: org.example.client, status: fg
04-06 05:46:25.648+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:46:25.648+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:46:25.648+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:46:25.658+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:25.658+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(625) > [APP 15374] Initial Launching, call the resume_cb
04-06 05:46:25.658+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:25.998+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15374) status(0)
04-06 05:46:26.168+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2374
04-06 05:46:26.178+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:46:26.178+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 15374.
04-06 05:46:26.939+0900 I/UXT     (15414): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:46:28.020+0900 E/EFL     (15374): ecore_x<15374> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223107377
04-06 05:46:28.020+0900 I/MY_LOG  (15374): Button pressed
04-06 05:46:28.100+0900 E/EFL     (15374): ecore_x<15374> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223107466
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: vconf_get_bool(2729) > vconf_get_bool(15374) : db/ise/keysound error
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:46:28.160+0900 I/MY_LOG  (15374): Button unpressed
04-06 05:46:28.280+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0615374636c69149142518
