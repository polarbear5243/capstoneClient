S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 10709
Date: 2017-04-06 04:18:17+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 10709, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000029d5
r2   = 0x00000006, r3   = 0xb40474c0
r4   = 0x00000002, r5   = 0xb4047000
r6   = 0xb674109c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5e6f708
r10  = 0xb7b2c858, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbed10c24
lr   = 0xb6637f18, pc   = 0xb6636b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     74032 KB
Buffers:     62440 KB
Cached:     289164 KB
VmPeak:     133908 KB
VmSize:     133904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28336 KB
VmRSS:       28336 KB
VmData:      45852 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10709 TID = 10709
10709 10710 10893 10894 10904 

Maps Information
aef2e000 af72d000 rw-p [stack:10904]
b0eee000 b0eff000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f0f000 b0f14000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1316000 b131e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1330000 b1b2f000 rw-p [stack:10894]
b1b2f000 b1b30000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b40000 b1b54000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b68000 b1b69000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b79000 b1b7c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b8d000 b1b8e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b9e000 b1ba0000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bb0000 b1bb2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bc2000 b1bd2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1be2000 b1bee000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c00000 b23ff000 rw-p [stack:10893]
b2730000 b2737000 r-xp /usr/lib/libefl-extension.so.0.1.0
b274a000 b2750000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2760000 b277b000 r-xp /opt/usr/apps/org.example.client/bin/client
b28d3000 b29b6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ed000 b2a15000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a27000 b3226000 rw-p [stack:10710]
b3226000 b3228000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3238000 b3242000 r-xp /lib/libnss_files-2.20-2014.11.so
b3253000 b325c000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326d000 b327e000 r-xp /lib/libnsl-2.20-2014.11.so
b3291000 b3297000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32a8000 b32a9000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d1000 b32d8000 r-xp /usr/lib/libminizip.so.1.0.0
b32e8000 b32ed000 r-xp /usr/lib/libstorage.so.0.1
b32fd000 b335c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3372000 b3386000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3396000 b33da000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ea000 b33f2000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3402000 b3432000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3445000 b34fe000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3512000 b3565000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3576000 b3591000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a1000 b3662000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3675000 b3685000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3695000 b36a2000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b3000 b36ba000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36ca000 b370b000 r-xp /usr/lib/libmdm.so.1.2.12
b371b000 b3723000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3732000 b3742000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3763000 b37c3000 r-xp /usr/lib/libasound.so.2.0.0
b37d5000 b37d8000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37e8000 b37eb000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37fb000 b3800000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3810000 b3811000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3821000 b382c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3840000 b3847000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3857000 b385d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386d000 b3872000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3882000 b389d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ad000 b38b4000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c4000 b38c7000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38d8000 b3906000 r-xp /usr/lib/libidn.so.11.5.44
b3916000 b392c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393d000 b3947000 r-xp /usr/lib/libcares.so.2.1.0
b3957000 b3961000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3971000 b3973000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3983000 b3984000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3994000 b3998000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39a9000 b39d1000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e2000 b3a0b000 r-xp /usr/lib/libturbojpeg.so
b3a2b000 b3a31000 r-xp /usr/lib/libgif.so.4.1.6
b3a41000 b3a87000 r-xp /usr/lib/libcurl.so.4.3.0
b3a98000 b3ab9000 r-xp /usr/lib/libexif.so.12.3.3
b3ad4000 b3ae9000 r-xp /usr/lib/libtts.so
b3afa000 b3b02000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b12000 b3bd8000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bf8000 b3cf0000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d0f000 b3ddd000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df4000 b3df6000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e06000 b3e0c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1c000 b3e3f000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e50000 b3e52000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e62000 b3e64000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e75000 b3e7a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e91000 b3e93000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea3000 b3eaa000 r-xp /usr/lib/libsensord-share.so
b3eba000 b3ed2000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee3000 b3ee6000 r-xp /usr/lib/libXv.so.1.0.0
b3ef6000 b3efb000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0b000 b3f10000 r-xp /usr/lib/libappcore-common.so.1.1
b3f20000 b3f27000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f3a000 b3f3e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f4f000 b402d000 r-xp /usr/lib/libCOREGL.so.4.0
b404d000 b4050000 r-xp /usr/lib/libuuid.so.1.3.0
b4060000 b4077000 r-xp /usr/lib/libblkid.so.1.1.0
b4088000 b408a000 r-xp /usr/lib/libXau.so.6.0.0
b409a000 b40e1000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f3000 b40f9000 r-xp /usr/lib/libjson-c.so.2.0.1
b410a000 b410e000 r-xp /usr/lib/libogg.so.0.7.1
b411e000 b4140000 r-xp /usr/lib/libvorbis.so.0.4.3
b4150000 b4234000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4250000 b4253000 r-xp /usr/lib/libEGL.so.1.4
b4264000 b426a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b427a000 b427c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428c000 b4299000 r-xp /usr/lib/libGLESv2.so.2.0
b42aa000 b430c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4321000 b4339000 r-xp /usr/lib/libmount.so.1.1.0
b434b000 b435f000 r-xp /usr/lib/libxcb.so.1.1.0
b436f000 b4376000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ae000 b43b0000 r-xp /usr/lib/libiri.so
b43c0000 b43cb000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43dc000 b4412000 r-xp /usr/lib/libpulse.so.0.16.2
b4423000 b4466000 r-xp /usr/lib/libsndfile.so.1.0.25
b447b000 b4490000 r-xp /lib/libexpat.so.1.5.2
b44a2000 b4560000 r-xp /usr/lib/libcairo.so.2.11200.14
b4574000 b457c000 r-xp /usr/lib/libdrm.so.2.4.0
b458c000 b458f000 r-xp /usr/lib/libdri2.so.0.0.0
b459f000 b45ed000 r-xp /usr/lib/libssl.so.1.0.0
b4602000 b460e000 r-xp /usr/lib/libeeze.so.1.13.0
b461f000 b4628000 r-xp /usr/lib/libethumb.so.1.13.0
b4638000 b463b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464b000 b4802000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ed000 b55f6000 r-xp /usr/lib/libXi.so.6.1.0
b5606000 b5608000 r-xp /usr/lib/libXgesture.so.7.0.0
b5618000 b561c000 r-xp /usr/lib/libXtst.so.6.1.0
b562c000 b5632000 r-xp /usr/lib/libXrender.so.1.3.0
b5642000 b5648000 r-xp /usr/lib/libXrandr.so.2.2.0
b5658000 b565a000 r-xp /usr/lib/libXinerama.so.1.0.0
b566b000 b566e000 r-xp /usr/lib/libXfixes.so.3.1.0
b567e000 b5689000 r-xp /usr/lib/libXext.so.6.4.0
b5699000 b569b000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ab000 b56ad000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bd000 b579f000 r-xp /usr/lib/libX11.so.6.3.0
b57b3000 b57ba000 r-xp /usr/lib/libXcursor.so.1.0.2
b57ca000 b57e2000 r-xp /usr/lib/libudev.so.1.6.0
b57e4000 b57e7000 r-xp /lib/libattr.so.1.1.0
b57f7000 b5817000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5818000 b581d000 r-xp /usr/lib/libffi.so.6.0.2
b582e000 b5846000 r-xp /lib/libz.so.1.2.8
b5856000 b5858000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5868000 b593d000 r-xp /usr/lib/libxml2.so.2.9.2
b5952000 b59ed000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a09000 b5a0c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1c000 b5a35000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a46000 b5a57000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6b000 b5ae5000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5afa000 b5afc000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0c000 b5b13000 r-xp /usr/lib/libembryo.so.1.13.0
b5b23000 b5b2d000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b3e000 b5b56000 r-xp /usr/lib/libpng12.so.0.50.0
b5b67000 b5b8a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bab000 b5bbf000 r-xp /usr/lib/libector.so.1.13.0
b5bd0000 b5be8000 r-xp /usr/lib/liblua-5.1.so
b5bf9000 b5c50000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c64000 b5c8c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9d000 b5cb0000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc1000 b5cfb000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0c000 b5d1a000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2a000 b5d32000 r-xp /usr/lib/libtbm.so.1.0.0
b5d42000 b5d4f000 r-xp /usr/lib/libeio.so.1.13.0
b5d5f000 b5d61000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d71000 b5d76000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d86000 b5d9d000 r-xp /usr/lib/libefreet.so.1.13.0
b5daf000 b5dcf000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ddf000 b5dff000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e01000 b5e07000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e17000 b5e28000 r-xp /usr/lib/libemotion.so.1.13.0
b5e39000 b5e40000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e50000 b5e5f000 r-xp /usr/lib/libeo.so.1.13.0
b5e70000 b5e82000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e93000 b5e98000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ea8000 b5ec1000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed1000 b5eee000 r-xp /usr/lib/libeet.so.1.13.0
b5f07000 b5f4f000 r-xp /usr/lib/libeina.so.1.13.0
b5f60000 b5f70000 r-xp /usr/lib/libefl.so.1.13.0
b5f81000 b6066000 r-xp /usr/lib/libicuuc.so.51.1
b6083000 b61c3000 r-xp /usr/lib/libicui18n.so.51.1
b61da000 b6212000 r-xp /usr/lib/libecore_x.so.1.13.0
b6224000 b6227000 r-xp /lib/libcap.so.2.21
b6237000 b6260000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6271000 b6278000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628a000 b62c1000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d2000 b63bd000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d0000 b6449000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645b000 b6460000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6470000 b647a000 r-xp /usr/lib/libvconf.so.0.2.45
b648a000 b648c000 r-xp /usr/lib/libvasum.so.0.3.1
b649c000 b649e000 r-xp /usr/lib/libttrace.so.1.1
b64ae000 b64b1000 r-xp /usr/lib/libiniparser.so.0
b64c1000 b64e7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f7000 b64fc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650d000 b6524000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6535000 b65a0000 r-xp /lib/libm-2.20-2014.11.so
b65b1000 b65b7000 r-xp /lib/librt-2.20-2014.11.so
b65c8000 b65d5000 r-xp /usr/lib/libunwind.so.8.0.1
b660b000 b672f000 r-xp /lib/libc-2.20-2014.11.so
b6744000 b675d000 r-xp /lib/libgcc_s-4.9.so.1
b676d000 b684f000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6860000 b688a000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689b000 b68d7000 r-xp /usr/lib/libsystemd.so.0.4.0
b68d9000 b695c000 r-xp /usr/lib/libedje.so.1.13.0
b696f000 b698d000 r-xp /usr/lib/libecore.so.1.13.0
b69ad000 b6b34000 r-xp /usr/lib/libevas.so.1.13.0
b6b69000 b6b7d000 r-xp /lib/libpthread-2.20-2014.11.so
b6b91000 b6dc5000 r-xp /usr/lib/libelementary.so.1.13.0
b6df4000 b6df8000 r-xp /usr/lib/libsmack.so.1.0.0
b6e08000 b6e0f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e1f000 b6e21000 r-xp /usr/lib/libdlog.so.0.0.0
b6e31000 b6e34000 r-xp /usr/lib/libbundle.so.0.1.22
b6e44000 b6e46000 r-xp /lib/libdl-2.20-2014.11.so
b6e57000 b6e6f000 r-xp /usr/lib/libaul.so.0.1.0
b6e83000 b6e88000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e99000 b6ea6000 r-xp /usr/lib/liblptcp.so
b6eb8000 b6ebc000 r-xp /usr/lib/libsys-assert.so
b6ecd000 b6eed000 r-xp /lib/ld-2.20-2014.11.so
b6efe000 b6f03000 r-xp /usr/bin/launchpad-loader
b77a9000 b7b88000 rw-p [heap]
becf1000 bed12000 rw-p [stack]
becf1000 bed12000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10709)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6636b84) [/lib/libc.so.6] + 0x2bb84
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
0;m
04-06 04:18:09.340+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
04-06 04:18:09.340+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
04-06 04:18:09.340+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
04-06 04:18:09.340+0900 E/LOCKSCREEN(  842): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-06 04:18:09.340+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-06 04:18:09.340+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-06 04:18:09.340+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-06 04:18:09.340+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-06 04:18:09.340+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-06 04:18:09.350+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:09.350+0900 W/LOCKSCREEN(  842): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2A00007] is [invisible]
04-06 04:18:09.350+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-06 04:18:09.350+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-06 04:18:09.360+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-06 04:18:09.360+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: PAUSE State: RUNNING
04-06 04:18:09.360+0900 I/CAPI_APPFW_APPLICATION(  842): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 04:18:09.360+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-06 04:18:09.360+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-06 04:18:09.360+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-06 04:18:09.360+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-06 04:18:09.360+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-06 04:18:09.360+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:09.360+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(4)
04-06 04:18:09.360+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(842)
04-06 04:18:09.360+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 842, appid: com.samsung.lockscreen, status: bg
04-06 04:18:09.360+0900 E/LOCKSCREEN(  842): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-06 04:18:09.370+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10336) status(3)
04-06 04:18:09.370+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 04:18:09.370+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 04:18:09.370+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(10336)
04-06 04:18:09.370+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10336, appid: org.example.client, status: fg
04-06 04:18:09.391+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 04:18:09.391+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:09.391+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
04-06 04:18:09.391+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:09.401+0900 I/APP_CORE(10336): appcore-efl.c: __do_app(514) > [APP 10336] Event: RESUME State: PAUSED
04-06 04:18:09.401+0900 I/CAPI_APPFW_APPLICATION(10336): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 04:18:09.411+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 04:18:09.461+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-06 04:18:09.461+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-06 04:18:09.461+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-06 04:18:09.461+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-06 04:18:09.461+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-06 04:18:09.461+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-06 04:18:09.471+0900 I/Tizen::App( 1231): (243) > App[com.samsung.weather-m-agent] pid[10861] terminate event is forwarded
04-06 04:18:09.471+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 04:18:09.471+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10861, ]
04-06 04:18:09.471+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 04:18:09.471+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-06 04:18:09.471+0900 I/Tizen::App( 1231): (512) > Not registered pid(10861)
04-06 04:18:09.471+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.weather-m-agent]
04-06 04:18:09.471+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:09.471+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 10861
04-06 04:18:09.471+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10861
04-06 04:18:09.471+0900 E/LOCKSCREEN(  842): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-06 04:18:09.471+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:09.471+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10861.
04-06 04:18:10.341+0900 E/EFL     (10336): ecore_x<10336> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=217809704
04-06 04:18:10.341+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=217809704
04-06 04:18:10.341+0900 W/STARTER (  709): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
04-06 04:18:10.341+0900 W/STARTER (  709): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
04-06 04:18:10.652+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 04:18:10.652+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 04:18:10.652+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 04:18:10.652+0900 E/STARTER (  709): )
04-06 04:18:10.662+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 04:18:10.662+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 04:18:10.662+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 04:18:10.672+0900 W/AUL     (  709): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
04-06 04:18:10.672+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 04:18:10.682+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-06 04:18:10.682+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 04:18:10.682+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 709
04-06 04:18:10.682+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 04:18:10.692+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 04:18:10.712+0900 I/GXT_SIB (  351): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 04:18:10.722+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6c466e9 in class 'Edje_Object'.
04-06 04:18:10.722+0900 E/UXT     (  351): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
04-06 04:18:10.722+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 04:18:10.722+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 04:18:10.722+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 04:18:10.752+0900 E/CAPI_APPFW_APPLICATION( 9964): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 04:18:10.752+0900 E/CAPI_APPFW_APPLICATION( 9964): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 04:18:10.752+0900 E/CAPI_APPFW_APPLICATION( 9964): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 04:18:10.752+0900 E/CAPI_APPFW_APPLICATION( 9964): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 04:18:10.752+0900 E/CAPI_APPFW_APPLICATION( 9964): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 04:18:10.752+0900 I/CAPI_APPFW_APPLICATION( 9964): app_main.c: ui_app_main(789) > app_efl_main
04-06 04:18:10.752+0900 I/CAPI_APPFW_APPLICATION( 9964): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 04:18:10.832+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9964, appid: com.samsung.task-mgr
04-06 04:18:10.832+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 04:18:10.832+0900 E/RESOURCED(  664): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
04-06 04:18:10.842+0900 W/TASK_MGR_LITE( 9964): task-mgr-lite.c: create_win(197) > changeable ui enabled success
04-06 04:18:10.842+0900 W/AUL     (  709): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9964)
04-06 04:18:10.842+0900 I/GXT_SIB ( 9964): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 04:18:10.892+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:10.892+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:10.892+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 04:18:10.912+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:10.922+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:10.922+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 04:18:10.922+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:10.932+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:10.932+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:10.932+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 04:18:10.942+0900 E/RUA     ( 9964): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
04-06 04:18:10.942+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-06 04:18:10.942+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 04:18:10.942+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10336
04-06 04:18:10.942+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 04:18:10.942+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-06 04:18:10.952+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-06 04:18:10.962+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:10.982+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:10.992+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:11.002+0900 I/APP_CORE( 9964): appcore-efl.c: __do_app(514) > [APP 9964] Event: RESET State: CREATED
04-06 04:18:11.002+0900 I/CAPI_APPFW_APPLICATION( 9964): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 04:18:11.002+0900 E/EFL     ( 9964): edje<9964> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:11.002+0900 E/EFL     ( 9964): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:11.002+0900 E/EFL     ( 9964): edje<9964> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:11.002+0900 E/EFL     ( 9964): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:11.012+0900 W/APP_CORE( 9964): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
04-06 04:18:11.012+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 04:18:11.012+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:11.032+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:11.042+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:11.062+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:11.122+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9964) status(0)
04-06 04:18:11.122+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9964) status(0)
04-06 04:18:11.122+0900 I/APP_CORE(10336): appcore-efl.c: __do_app(514) > [APP 10336] Event: PAUSE State: RUNNING
04-06 04:18:11.122+0900 I/CAPI_APPFW_APPLICATION(10336): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 04:18:11.122+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10336) status(4)
04-06 04:18:11.122+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(10336)
04-06 04:18:11.122+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10336, appid: org.example.client, status: bg
04-06 04:18:11.132+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9964) status(3)
04-06 04:18:11.132+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 04:18:11.132+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 04:18:11.132+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(9964)
04-06 04:18:11.132+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9964, appid: com.samsung.task-mgr, status: fg
04-06 04:18:11.132+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=217810491
04-06 04:18:11.132+0900 W/STARTER (  709): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-06 04:18:11.132+0900 I/APP_CORE( 9964): appcore-efl.c: __do_app(514) > [APP 9964] Event: RESUME State: CREATED
04-06 04:18:11.132+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 04:18:11.132+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 04:18:11.132+0900 E/STARTER (  709): )
04-06 04:18:11.142+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 04:18:11.142+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 04:18:11.152+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 04:18:11.152+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 04:18:11.152+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 04:18:11.152+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10336): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 27
04-06 04:18:11.152+0900 E/APP_CORE(10336): appcore-efl.c: _capture_and_make_file(1619) > win[7200002] widget[720] height[1280]
04-06 04:18:11.152+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 04:18:11.162+0900 I/APP_CORE( 9964): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 04:18:11.162+0900 I/APP_CORE( 9964): appcore-efl.c: __do_app(625) > [APP 9964] Initial Launching, call the resume_cb
04-06 04:18:11.162+0900 I/CAPI_APPFW_APPLICATION( 9964): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 04:18:11.302+0900 E/EFL     (10336): ecore_x<10336> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=217810491
04-06 04:18:11.873+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2127
04-06 04:18:11.903+0900 I/Tizen::App( 1231): (499) > LaunchedApp(com.samsung.task-mgr)
04-06 04:18:11.903+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for com.samsung.task-mgr, 9964.
04-06 04:18:11.933+0900 E/EFL     ( 9964): ecore_x<9964> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=217811297
04-06 04:18:12.063+0900 E/EFL     ( 9964): ecore_x<9964> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=217811419
04-06 04:18:12.383+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 04:18:12.383+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 04:18:12.383+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(9964)
04-06 04:18:12.383+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9964, appid: com.samsung.task-mgr, status: bg
04-06 04:18:12.383+0900 I/CAPI_APPFW_APPLICATION( 9964): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 04:18:12.383+0900 W/TASK_MGR_LITE( 9964): task-mgr-lite.c: _pause_app(406) > 
04-06 04:18:12.383+0900 I/CAPI_APPFW_APPLICATION( 9964): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 04:18:12.383+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 04:18:12.383+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10336
04-06 04:18:12.383+0900 W/AUL     ( 9964): launch.c: app_request_to_launchpad(396) > request cmd(4) to(10336)
04-06 04:18:12.383+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 4
04-06 04:18:12.393+0900 I/APP_CORE(10336): appcore-efl.c: __do_app(514) > [APP 10336] Event: TERMINATE State: PAUSED
04-06 04:18:12.393+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(10336), cmd(4)
04-06 04:18:12.393+0900 W/AUL     ( 9964): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-06 04:18:12.393+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 04:18:12.393+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 04:18:12.393+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 04:18:12.393+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 04:18:12.403+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10336): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-06 04:18:12.403+0900 E/APP_CORE(10336): appcore-efl.c: _capture_and_make_file(1619) > win[7200002] widget[720] height[1280]
04-06 04:18:12.403+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 04:18:12.403+0900 E/APP_CORE(10336): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 04:18:12.403+0900 E/TASK_MGR_LITE( 9964): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-06 04:18:12.403+0900 I/CAPI_APPFW_APPLICATION(10336): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 04:18:12.423+0900 E/TASK_MGR_LITE( 9964): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
04-06 04:18:12.423+0900 E/APP_CORE( 9964): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-06 04:18:12.423+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:12.433+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 04:18:12.433+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 04:18:12.433+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 04:18:12.433+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 04:18:12.433+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 04:18:12.484+0900 I/MALI    ( 9964): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=9964   close drm_fd=30 
04-06 04:18:12.484+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 04:18:12.524+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:12.534+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 04:18:12.534+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 04:18:12.534+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 04:18:12.544+0900 E/EFL     (  661): <661> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 04:18:12.544+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 04:18:12.594+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-06 04:18:12.594+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-06 04:18:12.624+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 04:18:12.634+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 04:18:12.744+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 04:18:12.774+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7ab42d8]
04-06 04:18:12.774+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 04:18:12.774+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7ab42d8
04-06 04:18:12.774+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 04:18:12.784+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 04:18:12.784+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 04:18:12.784+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 04:18:12.784+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 04:18:12.864+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9964 pgid = 9964
04-06 04:18:12.864+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(9964)
04-06 04:18:12.914+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 04:18:12.914+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 04:18:12.914+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 04:18:12.914+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 9964
04-06 04:18:12.914+0900 I/Tizen::App( 1231): (243) > App[com.samsung.task-mgr] pid[9964] terminate event is forwarded
04-06 04:18:12.914+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 04:18:12.914+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.task-mgr, 9964, ]
04-06 04:18:12.914+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 04:18:12.914+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.task-mgr)
04-06 04:18:12.914+0900 I/Tizen::App( 1231): (512) > Not registered pid(9964)
04-06 04:18:12.914+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.task-mgr]
04-06 04:18:12.914+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:12.914+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9964
04-06 04:18:12.914+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9964
04-06 04:18:12.924+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2130
04-06 04:18:12.944+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:12.944+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.task-mgr, 9964.
04-06 04:18:13.214+0900 I/UXT     (10878): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 04:18:13.274+0900 E/TBM     (10878): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 04:18:13.274+0900 I/MALI    (10878): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=10878   open drm_fd=30 
04-06 04:18:13.434+0900 E/EFL     (10878): edje<10878> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:13.434+0900 E/EFL     (10878): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:13.434+0900 E/EFL     (10878): edje<10878> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:13.434+0900 E/EFL     (10878): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:13.434+0900 E/EFL     (10878): edje<10878> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:13.434+0900 E/EFL     (10878): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:13.525+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=217812895
04-06 04:18:13.615+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=217812984
04-06 04:18:13.615+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 04:18:13.615+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 04:18:13.615+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 04:18:13.635+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 04:18:13.635+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 04:18:13.635+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 04:18:13.635+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 04:18:13.635+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 04:18:13.655+0900 I/abc     (10709): abc
04-06 04:18:13.655+0900 I/CAPI_APPFW_APPLICATION(10709): app_main.c: ui_app_main(789) > app_efl_main
04-06 04:18:13.655+0900 I/CAPI_APPFW_APPLICATION(10709): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 04:18:13.685+0900 E/TBM     (10709): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 04:18:13.735+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10709, appid: org.example.client
04-06 04:18:13.735+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 04:18:13.735+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(10709)
04-06 04:18:13.935+0900 D/basicui (10709): successed to load edc file
04-06 04:18:13.975+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:13.975+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:13.975+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 04:18:13.995+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 04:18:13.995+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:13.995+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:14.025+0900 I/MY_LOG  (10709): change
04-06 04:18:14.075+0900 I/APP_CORE(10709): appcore-efl.c: __do_app(514) > [APP 10709] Event: RESET State: CREATED
04-06 04:18:14.075+0900 I/CAPI_APPFW_APPLICATION(10709): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 04:18:14.085+0900 E/EFL     (10709): edje<10709> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:14.085+0900 E/EFL     (10709): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:14.085+0900 E/EFL     (10709): edje<10709> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:14.085+0900 E/EFL     (10709): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:14.095+0900 E/EFL     (10709): edje<10709> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 04:18:14.095+0900 E/EFL     (10709): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 04:18:14.095+0900 W/APP_CORE(10709): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 04:18:14.095+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 04:18:14.205+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 04:18:14.205+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 04:18:14.205+0900 I/APP_CORE(10709): appcore-efl.c: __do_app(514) > [APP 10709] Event: RESUME State: CREATED
04-06 04:18:14.205+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 04:18:14.215+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 04:18:14.215+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 04:18:14.215+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 04:18:14.215+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10709) status(3)
04-06 04:18:14.215+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(10709)
04-06 04:18:14.215+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10709, appid: org.example.client, status: fg
04-06 04:18:14.225+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 04:18:14.225+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 04:18:14.225+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 04:18:14.235+0900 I/APP_CORE(10709): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 04:18:14.235+0900 I/APP_CORE(10709): appcore-efl.c: __do_app(625) > [APP 10709] Initial Launching, call the resume_cb
04-06 04:18:14.235+0900 I/CAPI_APPFW_APPLICATION(10709): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 04:18:14.265+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 04:18:14.365+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
04-06 04:18:14.576+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10709) status(0)
04-06 04:18:14.766+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10336 pgid = 10336
04-06 04:18:14.766+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(10336)
04-06 04:18:14.786+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2131
04-06 04:18:14.796+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 04:18:14.796+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 10709.
04-06 04:18:14.826+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 04:18:14.826+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 04:18:14.826+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 04:18:14.836+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[10336] terminate event is forwarded
04-06 04:18:14.836+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 04:18:14.836+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 10336, ]
04-06 04:18:14.836+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 04:18:14.836+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 04:18:14.836+0900 I/Tizen::App( 1231): (512) > Not registered pid(10336)
04-06 04:18:14.836+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 04:18:14.836+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:14.836+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 10336
04-06 04:18:14.836+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10336
04-06 04:18:14.846+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2132
04-06 04:18:14.856+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:14.856+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 10336.
04-06 04:18:15.597+0900 I/UXT     (10899): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 04:18:17.378+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 04:18:17.388+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 04:18:17.388+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 04:18:17.398+0900 E/EFL     (10709): ecore_x<10709> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=217816757
04-06 04:18:17.398+0900 I/MY_LOG  (10709): Button pressed
04-06 04:18:17.488+0900 E/EFL     (10709): ecore_x<10709> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=217816857
04-06 04:18:17.498+0900 E/VCONF   (10709): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 04:18:17.498+0900 E/VCONF   (10709): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 04:18:17.498+0900 E/VCONF   (10709): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 04:18:17.498+0900 E/VCONF   (10709): vconf.c: vconf_get_bool(2729) > vconf_get_bool(10709) : db/ise/keysound error
04-06 04:18:17.498+0900 E/VCONF   (10709): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 04:18:17.498+0900 E/VCONF   (10709): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 04:18:17.548+0900 I/MY_LOG  (10709): Button unpressed
04-06 04:18:17.729+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10709 pgid = 10709
04-06 04:18:17.729+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(10709)
04-06 04:18:17.729+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:17.749+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 04:18:17.749+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 04:18:17.749+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 04:18:17.749+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 04:18:17.749+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 04:18:17.789+0900 E/EFL     (  661): <661> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 04:18:17.809+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 04:18:17.809+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 04:18:17.809+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 04:18:17.809+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 04:18:17.809+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 10709
04-06 04:18:17.809+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[10709] terminate event is forwarded
04-06 04:18:17.809+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 04:18:17.809+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 10709, ]
04-06 04:18:17.809+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 04:18:17.809+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 04:18:17.809+0900 I/Tizen::App( 1231): (512) > Not registered pid(10709)
04-06 04:18:17.809+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 04:18:17.809+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 04:18:17.809+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 04:18:17.809+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 04:18:17.809+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:17.809+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10709
04-06 04:18:17.809+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10709
04-06 04:18:17.809+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 04:18:17.819+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2136
04-06 04:18:17.819+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 04:18:17.829+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 04:18:17.829+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 10709.
04-06 04:18:17.849+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 04:18:17.859+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 04:18:17.859+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 04:18:17.879+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 04:18:17.879+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 04:18:17.879+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 04:18:17.879+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 04:18:17.879+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 04:18:17.889+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 04:18:17.919+0900 W/CRASH_MANAGER(10906): worker.c: worker_job(1199) > 0610709636c69149141989
