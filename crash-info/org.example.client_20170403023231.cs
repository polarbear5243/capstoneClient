S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6105
Date: 2017-04-03 02:32:31+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 6105, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000017d9
r2   = 0x00000006, r3   = 0xb40c64c0
r4   = 0x00000002, r5   = 0xb40c6000
r6   = 0xb67c009c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb7377f60
r10  = 0xbe9a1498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe9a102c
lr   = 0xb66b6f18, pc   = 0xb66b5b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    171268 KB
Buffers:     40728 KB
Cached:     324236 KB
VmPeak:      98496 KB
VmSize:      98492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19472 KB
VmRSS:       19472 KB
VmData:      30108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35652 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 6105 TID = 6105
6105 6111 6643 6644 

Maps Information
b139e000 b13a6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13b8000 b1bb7000 rw-p [stack:6644]
b1bb7000 b1bb8000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc8000 b1bdc000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bf0000 b1bf1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c01000 b1c04000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c15000 b1c16000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c26000 b1c28000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c38000 b1c3a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c4a000 b1c5a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c6a000 b1c76000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c88000 b2487000 rw-p [stack:6643]
b27b8000 b27bf000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27d2000 b27d8000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27e8000 b27fa000 r-xp /opt/usr/apps/org.example.client/bin/client
b2952000 b2a35000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a6c000 b2a94000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aa6000 b32a5000 rw-p [stack:6111]
b32a5000 b32a7000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32b7000 b32c1000 r-xp /lib/libnss_files-2.20-2014.11.so
b32d2000 b32db000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32ec000 b32fd000 r-xp /lib/libnsl-2.20-2014.11.so
b3310000 b3316000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3327000 b3328000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3350000 b3357000 r-xp /usr/lib/libminizip.so.1.0.0
b3367000 b336c000 r-xp /usr/lib/libstorage.so.0.1
b337c000 b33db000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33f1000 b3405000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3415000 b3459000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3469000 b3471000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3481000 b34b1000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34c4000 b357d000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3591000 b35e4000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35f5000 b3610000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3620000 b36e1000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36f4000 b3704000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3714000 b3721000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3732000 b3739000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3749000 b378a000 r-xp /usr/lib/libmdm.so.1.2.12
b379a000 b37a2000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37b1000 b37c1000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37e2000 b3842000 r-xp /usr/lib/libasound.so.2.0.0
b3854000 b3857000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3867000 b386a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b387a000 b387f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b388f000 b3890000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38a0000 b38ab000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38bf000 b38c6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38d6000 b38dc000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38ec000 b38f1000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3901000 b391c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b392c000 b3933000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3943000 b3946000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3957000 b3985000 r-xp /usr/lib/libidn.so.11.5.44
b3995000 b39ab000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39bc000 b39c6000 r-xp /usr/lib/libcares.so.2.1.0
b39d6000 b39e0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39f0000 b39f2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a13000 b3a17000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a28000 b3a50000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a61000 b3a8a000 r-xp /usr/lib/libturbojpeg.so
b3aaa000 b3ab0000 r-xp /usr/lib/libgif.so.4.1.6
b3ac0000 b3b06000 r-xp /usr/lib/libcurl.so.4.3.0
b3b17000 b3b38000 r-xp /usr/lib/libexif.so.12.3.3
b3b53000 b3b68000 r-xp /usr/lib/libtts.so
b3b79000 b3b81000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b91000 b3c57000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c77000 b3d6f000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d8e000 b3e5c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e73000 b3e75000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e85000 b3e8b000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e9b000 b3ebe000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ecf000 b3ed1000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ee1000 b3ee3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ef4000 b3ef9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f10000 b3f12000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f22000 b3f29000 r-xp /usr/lib/libsensord-share.so
b3f39000 b3f51000 r-xp /usr/lib/libsensor.so.1.1.0
b3f62000 b3f65000 r-xp /usr/lib/libXv.so.1.0.0
b3f75000 b3f7a000 r-xp /usr/lib/libutilX.so.1.1.0
b3f8a000 b3f8f000 r-xp /usr/lib/libappcore-common.so.1.1
b3f9f000 b3fa6000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fb9000 b3fbd000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fce000 b40ac000 r-xp /usr/lib/libCOREGL.so.4.0
b40cc000 b40cf000 r-xp /usr/lib/libuuid.so.1.3.0
b40df000 b40f6000 r-xp /usr/lib/libblkid.so.1.1.0
b4107000 b4109000 r-xp /usr/lib/libXau.so.6.0.0
b4119000 b4160000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4172000 b4178000 r-xp /usr/lib/libjson-c.so.2.0.1
b4189000 b418d000 r-xp /usr/lib/libogg.so.0.7.1
b419d000 b41bf000 r-xp /usr/lib/libvorbis.so.0.4.3
b41cf000 b42b3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42cf000 b42d2000 r-xp /usr/lib/libEGL.so.1.4
b42e3000 b42e9000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42f9000 b42fb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b430b000 b4318000 r-xp /usr/lib/libGLESv2.so.2.0
b4329000 b438b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43a0000 b43b8000 r-xp /usr/lib/libmount.so.1.1.0
b43ca000 b43de000 r-xp /usr/lib/libxcb.so.1.1.0
b43ee000 b43f5000 r-xp /lib/libcrypt-2.20-2014.11.so
b442d000 b442f000 r-xp /usr/lib/libiri.so
b443f000 b444a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b445b000 b4491000 r-xp /usr/lib/libpulse.so.0.16.2
b44a2000 b44e5000 r-xp /usr/lib/libsndfile.so.1.0.25
b44fa000 b450f000 r-xp /lib/libexpat.so.1.5.2
b4521000 b45df000 r-xp /usr/lib/libcairo.so.2.11200.14
b45f3000 b45fb000 r-xp /usr/lib/libdrm.so.2.4.0
b460b000 b460e000 r-xp /usr/lib/libdri2.so.0.0.0
b461e000 b466c000 r-xp /usr/lib/libssl.so.1.0.0
b4681000 b468d000 r-xp /usr/lib/libeeze.so.1.13.0
b469e000 b46a7000 r-xp /usr/lib/libethumb.so.1.13.0
b46b7000 b46ba000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46ca000 b4881000 r-xp /usr/lib/libcrypto.so.1.0.0
b566c000 b5675000 r-xp /usr/lib/libXi.so.6.1.0
b5685000 b5687000 r-xp /usr/lib/libXgesture.so.7.0.0
b5697000 b569b000 r-xp /usr/lib/libXtst.so.6.1.0
b56ab000 b56b1000 r-xp /usr/lib/libXrender.so.1.3.0
b56c1000 b56c7000 r-xp /usr/lib/libXrandr.so.2.2.0
b56d7000 b56d9000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ea000 b56ed000 r-xp /usr/lib/libXfixes.so.3.1.0
b56fd000 b5708000 r-xp /usr/lib/libXext.so.6.4.0
b5718000 b571a000 r-xp /usr/lib/libXdamage.so.1.1.0
b572a000 b572c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b573c000 b581e000 r-xp /usr/lib/libX11.so.6.3.0
b5832000 b5839000 r-xp /usr/lib/libXcursor.so.1.0.2
b5849000 b5861000 r-xp /usr/lib/libudev.so.1.6.0
b5863000 b5866000 r-xp /lib/libattr.so.1.1.0
b5876000 b5896000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5897000 b589c000 r-xp /usr/lib/libffi.so.6.0.2
b58ad000 b58c5000 r-xp /lib/libz.so.1.2.8
b58d5000 b58d7000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58e7000 b59bc000 r-xp /usr/lib/libxml2.so.2.9.2
b59d1000 b5a6c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a88000 b5a8b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a9b000 b5ab4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ac5000 b5ad6000 r-xp /lib/libresolv-2.20-2014.11.so
b5aea000 b5b64000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b79000 b5b7b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b8b000 b5b92000 r-xp /usr/lib/libembryo.so.1.13.0
b5ba2000 b5bac000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bbd000 b5bd5000 r-xp /usr/lib/libpng12.so.0.50.0
b5be6000 b5c09000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c2a000 b5c3e000 r-xp /usr/lib/libector.so.1.13.0
b5c4f000 b5c67000 r-xp /usr/lib/liblua-5.1.so
b5c78000 b5ccf000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ce3000 b5d0b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d1c000 b5d2f000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d40000 b5d7a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d8b000 b5d99000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5da9000 b5db1000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc1000 b5dce000 r-xp /usr/lib/libeio.so.1.13.0
b5dde000 b5de0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5df0000 b5df5000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e05000 b5e1c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e2e000 b5e4e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e5e000 b5e7e000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e80000 b5e86000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e96000 b5ea7000 r-xp /usr/lib/libemotion.so.1.13.0
b5eb8000 b5ebf000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ecf000 b5ede000 r-xp /usr/lib/libeo.so.1.13.0
b5eef000 b5f01000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f12000 b5f17000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f27000 b5f40000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f50000 b5f6d000 r-xp /usr/lib/libeet.so.1.13.0
b5f86000 b5fce000 r-xp /usr/lib/libeina.so.1.13.0
b5fdf000 b5fef000 r-xp /usr/lib/libefl.so.1.13.0
b6000000 b60e5000 r-xp /usr/lib/libicuuc.so.51.1
b6102000 b6242000 r-xp /usr/lib/libicui18n.so.51.1
b6259000 b6291000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a3000 b62a6000 r-xp /lib/libcap.so.2.21
b62b6000 b62df000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62f0000 b62f7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6309000 b6340000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6351000 b643c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b644f000 b64c8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64da000 b64df000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64ef000 b64f9000 r-xp /usr/lib/libvconf.so.0.2.45
b6509000 b650b000 r-xp /usr/lib/libvasum.so.0.3.1
b651b000 b651d000 r-xp /usr/lib/libttrace.so.1.1
b652d000 b6530000 r-xp /usr/lib/libiniparser.so.0
b6540000 b6566000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6576000 b657b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b658c000 b65a3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b4000 b661f000 r-xp /lib/libm-2.20-2014.11.so
b6630000 b6636000 r-xp /lib/librt-2.20-2014.11.so
b6647000 b6654000 r-xp /usr/lib/libunwind.so.8.0.1
b668a000 b67ae000 r-xp /lib/libc-2.20-2014.11.so
b67c3000 b67dc000 r-xp /lib/libgcc_s-4.9.so.1
b67ec000 b68ce000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68df000 b6909000 r-xp /usr/lib/libdbus-1.so.3.8.12
b691a000 b6956000 r-xp /usr/lib/libsystemd.so.0.4.0
b6958000 b69db000 r-xp /usr/lib/libedje.so.1.13.0
b69ee000 b6a0c000 r-xp /usr/lib/libecore.so.1.13.0
b6a2c000 b6bb3000 r-xp /usr/lib/libevas.so.1.13.0
b6be8000 b6bfc000 r-xp /lib/libpthread-2.20-2014.11.so
b6c10000 b6e44000 r-xp /usr/lib/libelementary.so.1.13.0
b6e73000 b6e77000 r-xp /usr/lib/libsmack.so.1.0.0
b6e87000 b6e8e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e9e000 b6ea0000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb0000 b6eb3000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec3000 b6ec5000 r-xp /lib/libdl-2.20-2014.11.so
b6ed6000 b6eee000 r-xp /usr/lib/libaul.so.0.1.0
b6f02000 b6f07000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f18000 b6f25000 r-xp /usr/lib/liblptcp.so
b6f37000 b6f3b000 r-xp /usr/lib/libsys-assert.so
b6f4c000 b6f6c000 r-xp /lib/ld-2.20-2014.11.so
b6f7d000 b6f82000 r-xp /usr/bin/launchpad-loader
b7274000 b749f000 rw-p [heap]
be981000 be9a2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6105)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66b5b84) [/lib/libc.so.6] + 0x2bb84
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
0 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
04-03 02:32:14.885+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
04-03 02:32:14.885+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
04-03 02:32:14.885+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
04-03 02:32:14.895+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-03 02:32:14.906+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
04-03 02:32:14.906+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 02:32:14.916+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 2:32
04-03 02:32:14.916+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 2:32"
04-03 02:32:14.916+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 2:32"
04-03 02:32:14.916+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 02:32:14.916+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146403261 Time: <font_size=31> </font_size> <font_size=31> 오전 2:32</font_size></font>"
04-03 02:32:14.916+0900 I/INDICATOR(  630): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
04-03 02:32:14.916+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 02:32:14.916+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:14.916+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:14.916+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:14.916+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 02:32:14.916+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 02:32:15.136+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
04-03 02:32:15.136+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
04-03 02:32:15.136+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
04-03 02:32:15.136+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
04-03 02:32:15.136+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-03 02:32:15.136+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
04-03 02:32:15.136+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
04-03 02:32:15.136+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-03 02:32:15.136+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-03 02:32:15.136+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 02:32:15.146+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(2508) > caller pid : 845
04-03 02:32:15.146+0900 I/AUL_AMD (  611): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-03 02:32:15.156+0900 E/RESOURCED(  634): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 02:32:15.156+0900 W/AUL_AMD (  611): amd_launch.c: start_process(638) > child process: 6396
04-03 02:32:15.206+0900 W/AUL_AMD (  611): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 6396
04-03 02:32:15.206+0900 W/AUL     (  611): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6396, appid: com.samsung.weather-m-agent
04-03 02:32:15.226+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6396)
04-03 02:32:15.246+0900 I/Tizen::App( 1235): (499) > LaunchedApp(com.samsung.weather-m-agent)
04-03 02:32:15.246+0900 I/Tizen::App( 1235): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6396.
04-03 02:32:15.406+0900 E/weather-agent( 6396): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
04-03 02:32:15.406+0900 E/weather-common( 6396): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
04-03 02:32:15.406+0900 E/weather-agent( 6396): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
04-03 02:32:15.426+0900 I/MESSAGE_PORT( 6396): message-port.c: __initialize(872) > initialize
04-03 02:32:15.426+0900 I/MESSAGE_PORT( 6396): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-03 02:32:15.466+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
04-03 02:32:15.466+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-03 02:32:15.466+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 02:32:15.466+0900 E/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
04-03 02:32:15.466+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
04-03 02:32:15.466+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 1305): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-03 02:32:15.476+0900 E/MESSAGE_PORT( 6396): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 7.000000[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 16.400000[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 36.900000[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 18[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1491143948[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
04-03 02:32:15.476+0900 E/weather-common( 6396): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
04-03 02:32:15.476+0900 E/weather-agent( 6396): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
04-03 02:32:15.476+0900 E/weather-agent( 6396): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-03 02:32:15.476+0900 I/MESSAGE_PORT( 6396): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-03 02:32:15.476+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 02:32:15.496+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 02:32:15.546+0900 I/Tizen::System( 1235): (280) > The screen has been turned on.
04-03 02:32:15.546+0900 I/Tizen::Io( 1235): (729) > Entry not found
04-03 02:32:15.556+0900 E/weather-widget( 1305): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-03 02:32:15.556+0900 E/weather-widget( 1305): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-03 02:32:15.586+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
04-03 02:32:15.596+0900 I/Tizen::System( 1235): (157) > change brightness system value.
04-03 02:32:15.596+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.596+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.596+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.596+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 02:32:15.606+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 02:32:15.696+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7324942
04-03 02:32:15.796+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7325041
04-03 02:32:15.796+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
04-03 02:32:15.796+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
04-03 02:32:15.796+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-03 02:32:15.876+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_create(409) > New handle created[0xb8ce99b8]
04-03 02:32:15.886+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_get_type(463) > Connected Network = 2
04-03 02:32:15.886+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_destroy(427) > Destroy handle: 0xb8ce99b8
04-03 02:32:15.886+0900 E/weather-common( 1305): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-03 02:32:15.886+0900 W/LOCATION( 1305): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
04-03 02:32:15.886+0900 E/weather-common( 1305): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
04-03 02:32:15.916+0900 E/weather-widget( 1305): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
04-03 02:32:15.916+0900 I/CAPI_WIDGET_APPLICATION( 1305): widget_app.c: __provider_update_cb(287) > received updating signal
04-03 02:32:15.916+0900 E/EFL     ( 1305): edje<1305> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-03 02:32:15.947+0900 E/EFL     ( 1305): evas_main<1305> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80144e2d is not stable during recalc loop
04-03 02:32:15.977+0900 E/EFL     ( 1305): evas_main<1305> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80144e2d is not stable during recalc loop
04-03 02:32:15.987+0900 E/EFL     ( 1305): edje<1305> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-03 02:32:15.997+0900 E/weather-widget( 1305): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-03 02:32:15.997+0900 E/cluster-home(  862): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
04-03 02:32:16.007+0900 W/cluster-view(  862): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-03 02:32:16.017+0900 E/weather-widget( 1305): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-03 02:32:16.027+0900 E/weather-common( 1305): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-03 02:32:16.067+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_create(409) > New handle created[0xb8e921c0]
04-03 02:32:16.067+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_get_type(463) > Connected Network = 2
04-03 02:32:16.067+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_destroy(427) > Destroy handle: 0xb8e921c0
04-03 02:32:16.067+0900 E/weather-common( 1305): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-03 02:32:16.067+0900 E/weather-widget( 1305): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-03 02:32:16.067+0900 I/CAPI_WIDGET_APPLICATION( 1305): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-03 02:32:16.067+0900 I/CAPI_WIDGET_APPLICATION( 1305): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-03 02:32:16.067+0900 W/AUL     ( 1305): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1305, appid: com.samsung.weather-m-widget, status: fg
04-03 02:32:16.127+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
04-03 02:32:16.127+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
04-03 02:32:16.127+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
04-03 02:32:16.127+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-03 02:32:16.127+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-03 02:32:16.127+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-03 02:32:16.127+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-03 02:32:16.127+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-03 02:32:16.127+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-03 02:32:16.137+0900 E/EFL     (  337): eo<337> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 02:32:16.147+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
04-03 02:32:16.147+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-03 02:32:16.147+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-03 02:32:16.147+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-03 02:32:16.147+0900 I/APP_CORE(  862): appcore-efl.c: __do_app(514) > [APP 862] Event: RESUME State: PAUSED
04-03 02:32:16.147+0900 I/CAPI_APPFW_APPLICATION(  862): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-03 02:32:16.147+0900 E/cluster-home(  862): homescreen.cpp: OnResume(233) >  app resume
04-03 02:32:16.157+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
04-03 02:32:16.157+0900 W/AUL     (  611): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
04-03 02:32:16.157+0900 W/AUL     (  611): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
04-03 02:32:16.157+0900 E/EFL     (  337): eo<337> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 02:32:16.157+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3328) > pid(862) status(3)
04-03 02:32:16.157+0900 W/AUL_AMD (  611): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 02:32:16.157+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-03 02:32:16.157+0900 W/AUL     (  611): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(862)
04-03 02:32:16.157+0900 W/AUL     (  611): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 862, appid: com.samsung.homescreen, status: fg
04-03 02:32:16.177+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
04-03 02:32:16.177+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-03 02:32:16.177+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-03 02:32:16.177+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-03 02:32:16.177+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-03 02:32:16.177+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-03 02:32:16.177+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-03 02:32:16.177+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-03 02:32:16.187+0900 I/Tizen::System( 1235): (259) > Active app [com.samsun], current [com.samsun] 
04-03 02:32:16.187+0900 I/Tizen::System( 1235): (273) > Current App[com.samsun] is already actived.
04-03 02:32:16.187+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
04-03 02:32:16.207+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 02:32:16.247+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-03 02:32:16.247+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-03 02:32:16.247+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-03 02:32:16.247+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-03 02:32:16.247+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-03 02:32:16.257+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-03 02:32:16.477+0900 E/weather-agent( 6396): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-03 02:32:16.477+0900 I/CAPI_APPFW_APPLICATION( 6396): service_app_main.c: service_app_exit(446) > service_app_exit
04-03 02:32:16.477+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 22
04-03 02:32:16.477+0900 E/weather-agent( 6396): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-03 02:32:16.477+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(1201) > app status : 5
04-03 02:32:16.607+0900 W/AUL_AMD (  611): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-03 02:32:16.617+0900 I/Tizen::App( 1235): (243) > App[com.samsung.weather-m-agent] pid[6396] terminate event is forwarded
04-03 02:32:16.617+0900 I/Tizen::System( 1235): (256) > osp.accessorymanager.service provider is found.
04-03 02:32:16.617+0900 I/Tizen::System( 1235): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6396, ]
04-03 02:32:16.617+0900 I/Tizen::System( 1235): (256) > osp.system.service provider is found.
04-03 02:32:16.617+0900 I/Tizen::App( 1235): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-03 02:32:16.617+0900 I/Tizen::App( 1235): (512) > Not registered pid(6396)
04-03 02:32:16.617+0900 I/Tizen::System( 1235): (246) > Terminated app [com.samsung.weather-m-agent]
04-03 02:32:16.617+0900 I/Tizen::Io( 1235): (729) > Entry not found
04-03 02:32:16.617+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6396
04-03 02:32:16.627+0900 W/AUL_AMD (  611): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6396
04-03 02:32:16.627+0900 I/Tizen::System( 1235): (157) > change brightness system value.
04-03 02:32:16.627+0900 I/Tizen::App( 1235): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6396.
04-03 02:32:16.687+0900 E/PKGMGR_SERVER( 6438): pkgmgr-server.c: main(2414) > package manager server start
04-03 02:32:16.747+0900 E/PKGMGR  ( 6436): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 02:32:16.787+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 02:32:16.787+0900 E/AUL_AMD (  611): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 6042
04-03 02:32:16.797+0900 W/AUL_AMD (  611): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 02:32:16.807+0900 E/PKGMGR_SERVER( 6438): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6441]
04-03 02:32:18.759+0900 E/PKGMGR_SERVER( 6438): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 02:32:18.759+0900 E/PKGMGR_SERVER( 6438): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 02:32:20.711+0900 E/PKGMGR  ( 6525): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-03 02:32:20.791+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: main(2414) > package manager server start
04-03 02:32:20.831+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-03 02:32:20.841+0900 E/PKGMGR_SERVER( 6527): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-03 02:32:20.841+0900 E/PKGMGR  ( 6525): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[65250002]
04-03 02:32:20.991+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-03 02:32:20.991+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-03 02:32:20.991+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:20.991+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:20.991+0900 W/AUL_AMD (  611): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-03 02:32:21.001+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 02:32:21.001+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [30]
04-03 02:32:21.001+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 02:32:21.001+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:21.001+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:21.142+0900 W/CERT_SVC_VCORE( 6530): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 02:32:21.182+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
04-03 02:32:21.202+0900 E/rpm-installer( 6530): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-03 02:32:21.202+0900 E/rpm-installer( 6530): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-03 02:32:21.262+0900 E/PKGMGR_PARSER( 6530): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-03 02:32:21.272+0900 I/PRIVACY-MANAGER-CLIENT( 6530): SocketClient.cpp: SocketClient(37) > Client created
04-03 02:32:21.272+0900 I/PRIVACY-MANAGER-CLIENT( 6530): SocketClient.cpp: connect(62) > Client connected
04-03 02:32:21.272+0900 I/PRIVACY-MANAGER-SERVER(  925): SocketService.cpp: mainloop(230) > Got incoming connection
04-03 02:32:21.282+0900 I/PRIVACY-MANAGER-CLIENT( 6530): SocketClient.cpp: disconnect(72) > Client disconnected
04-03 02:32:21.282+0900 E/PKGMGR_CERT( 6530): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-03 02:32:21.282+0900 E/PKGMGR_CERT( 6530): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-03 02:32:21.292+0900 E/PKGMGR_CERT( 6530): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-03 02:32:21.322+0900 E/rpm-installer( 6530): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-03 02:32:21.332+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:21.332+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:21.332+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-03 02:32:21.332+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-03 02:32:21.332+0900 E/ESD     (  887): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-03 02:32:21.332+0900 W/AUL_AMD (  611): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-03 02:32:21.332+0900 W/ISF_PANEL_EFL(  672): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-03 02:32:21.342+0900 W/ISF_PANEL_EFL(  672): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-03 02:32:21.472+0900 W/AUL_AMD (  611): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-03 02:32:22.753+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 02:32:22.983+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6530]
04-03 02:32:23.994+0900 E/PKGMGR  ( 6578): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-03 02:32:24.024+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-03 02:32:24.034+0900 E/PKGMGR_INFO( 6527): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-03 02:32:24.034+0900 E/rpm-installer( 6527): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-03 02:32:24.044+0900 E/PKGMGR_SERVER( 6527): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-03 02:32:24.054+0900 E/PKGMGR  ( 6578): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[65780002]
04-03 02:32:24.175+0900 E/PKGMGR_INSTALLER( 6580): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-03 02:32:24.175+0900 E/rpm-installer( 6580): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-03 02:32:24.185+0900 E/rpm-installer( 6580): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-03 02:32:24.185+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-03 02:32:24.185+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 02:32:24.185+0900 E/rpm-installer( 6580): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-03 02:32:24.185+0900 E/rpm-installer( 6580): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 02:32:24.235+0900 W/CERT_SVC_VCORE( 6580): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 02:32:24.285+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-03 02:32:24.285+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-03 02:32:24.285+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.285+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.295+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.295+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 02:32:24.295+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.295+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [30]
04-03 02:32:24.295+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 02:32:24.465+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-03 02:32:24.465+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-03 02:32:24.465+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-03 02:32:24.465+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 02:32:24.465+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-03 02:32:24.465+0900 E/rpm-installer( 6580): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-03 02:32:24.475+0900 E/PKGMGR_PARSER( 6580): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-03 02:32:24.475+0900 E/PKGMGR_PARSER( 6580): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-03 02:32:24.505+0900 I/PRIVACY-MANAGER-CLIENT( 6580): SocketClient.cpp: SocketClient(37) > Client created
04-03 02:32:24.715+0900 E/PKGMGR_PARSER( 6580): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-03 02:32:24.735+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-03 02:32:24.735+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-03 02:32:24.735+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-03 02:32:24.735+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-03 02:32:24.735+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-03 02:32:24.735+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-03 02:32:24.745+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-03 02:32:24.745+0900 E/PKGMGR_CERT( 6580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-03 02:32:24.755+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.755+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.755+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-03 02:32:24.755+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [60]
04-03 02:32:24.755+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-03 02:32:24.755+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 02:32:24.765+0900 E/rpm-installer( 6580): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 02:32:24.785+0900 E/rpm-installer( 6580): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-03 02:32:24.795+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.795+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-03 02:32:24.795+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:24.795+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [100]
04-03 02:32:24.795+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-03 02:32:26.667+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 02:32:26.667+0900 I/Tizen::App( 1235): (78) > Installation is Completed. [Package = org.example.client]
04-03 02:32:26.667+0900 I/Tizen::App( 1235): (671) > Enter. package(org.example.client), installationResult(0)
04-03 02:32:26.677+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-03 02:32:26.677+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-03 02:32:26.677+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-03 02:32:26.697+0900 I/Tizen::App( 1235): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 02:32:26.697+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 02:32:26.697+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 02:32:26.697+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 02:32:26.697+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 02:32:26.697+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 02:32:26.707+0900 I/Tizen::App( 1235): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 02:32:26.707+0900 W/ISF_PANEL_EFL(  672): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 02:32:26.707+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 02:32:26.707+0900 E/HOME_APPS(  862): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 02:32:26.717+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 02:32:26.717+0900 W/HOME_APPS(  862): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 02:32:26.717+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:26.717+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 02:32:26.717+0900 I/Tizen::App( 1235): (416) > appName = [client]
04-03 02:32:26.717+0900 I/Tizen::App( 1235): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 02:32:26.727+0900 E/PKGMGR_INFO( 1235): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 02:32:26.727+0900 I/Tizen::App( 1235): (683) > Application count(1) in this package
04-03 02:32:26.727+0900 I/Tizen::App( 1235): (840) > Enter.
04-03 02:32:26.727+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6580]
04-03 02:32:26.727+0900 I/Tizen::App( 1235): (703) > Exit.
04-03 02:32:26.727+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-03 02:32:26.737+0900 E/util-view(  862): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 02:32:26.737+0900 I/Tizen::App( 1235): (416) > appName = [client]
04-03 02:32:26.737+0900 I/Tizen::App( 1235): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 02:32:26.737+0900 I/Tizen::App( 1235): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 02:32:26.737+0900 I/Tizen::App( 1235): (131) > Enter
04-03 02:32:26.747+0900 I/Tizen::App( 1235): (137) > org.example.client does not have launch condition
04-03 02:32:26.747+0900 I/Tizen::App( 1235): (883) > Exit.
04-03 02:32:26.757+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 02:32:26.757+0900 E/PKGMGR_SERVER( 6527): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 02:32:26.757+0900 W/HOME_APPS(  862): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 02:32:30.921+0900 W/AUL     ( 6636): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 02:32:30.921+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 02:32:30.931+0900 I/AUL     (  611): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 02:32:30.941+0900 I/AUL     (  611): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 02:32:30.941+0900 E/AUL_AMD (  611): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 02:32:30.941+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(2508) > caller pid : 6636
04-03 02:32:30.941+0900 E/AUL_AMD (  611): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 02:32:30.951+0900 E/RESOURCED(  634): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 02:32:30.951+0900 E/RESOURCED(  634): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 02:32:30.951+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(3052) > pad pid(-5)
04-03 02:32:30.951+0900 W/AUL_PAD ( 1507): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-03 02:32:30.951+0900 W/AUL_PAD ( 1507): launchpad.c: __send_result_to_caller(267) > Check app launching
04-03 02:32:30.971+0900 I/abc     ( 6105): abc
04-03 02:32:30.971+0900 I/CAPI_APPFW_APPLICATION( 6105): app_main.c: ui_app_main(789) > app_efl_main
04-03 02:32:30.971+0900 I/CAPI_APPFW_APPLICATION( 6105): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 02:32:31.001+0900 E/TBM     ( 6105): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 02:32:31.061+0900 W/AUL     (  611): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6105, appid: org.example.client
04-03 02:32:31.061+0900 E/AUL     (  611): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 02:32:31.071+0900 W/AUL     ( 6636): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6105)
04-03 02:32:31.251+0900 W/CRASH_MANAGER( 6650): worker.c: worker_job(1199) > 0606105636c69149115435
