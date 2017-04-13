S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 26392
Date: 2017-04-13 18:14:28+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 26392, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xb7cafd20
r2   = 0x000003ff, r3   = 0x00000000
r4   = 0xb6f59114, r5   = 0xb677b470
r6   = 0xb7c7d3a8, r7   = 0x00000123
r8   = 0x80061b0f, r9   = 0xb5f12708
r10  = 0xb7b78598, fp   = 0xbea41ddc
ip   = 0x00000000, sp   = 0xbea41db0
lr   = 0xb40ea4c0, pc   = 0xb677b4b4
cpsr = 0x800f0010

Memory Information
MemTotal:   987012 KB
MemFree:     57184 KB
Buffers:     66708 KB
Cached:     355400 KB
VmPeak:     134448 KB
VmSize:     133456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27924 KB
VmRSS:       27460 KB
VmData:      45588 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35732 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 26392 TID = 26392
26392 26393 26717 26718 26727 

Maps Information
af22e000 afa2d000 rw-p [stack:26727]
b13ad000 b13b5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c7000 b1bc6000 rw-p [stack:26718]
b1bc6000 b1bc7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd7000 b1beb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bff000 b1c00000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c10000 b1c13000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c24000 b1c25000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c35000 b1c37000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c47000 b1c49000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c59000 b1c69000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c79000 b1c85000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c97000 b2496000 rw-p [stack:26717]
b27c7000 b27ce000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e1000 b27e7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f7000 b281d000 r-xp /opt/usr/apps/org.example.client/bin/client
b2976000 b2a59000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a90000 b2ab8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aca000 b32c9000 rw-p [stack:26393]
b32c9000 b32cb000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32db000 b32e5000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f6000 b32ff000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3310000 b3321000 r-xp /lib/libnsl-2.20-2014.11.so
b3334000 b333a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b334b000 b334c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3374000 b337b000 r-xp /usr/lib/libminizip.so.1.0.0
b338b000 b3390000 r-xp /usr/lib/libstorage.so.0.1
b33a0000 b33ff000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3415000 b3429000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3439000 b347d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b348d000 b3495000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34a5000 b34d5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34e8000 b35a1000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35b5000 b3608000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3619000 b3634000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3644000 b3705000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3718000 b3728000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3738000 b3745000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3756000 b375d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b376d000 b37ae000 r-xp /usr/lib/libmdm.so.1.2.12
b37be000 b37c6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37d5000 b37e5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3806000 b3866000 r-xp /usr/lib/libasound.so.2.0.0
b3878000 b387b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b388b000 b388e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b389e000 b38a3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b3000 b38b4000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38c4000 b38cf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e3000 b38ea000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38fa000 b3900000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3910000 b3915000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3925000 b3940000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3950000 b3957000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3967000 b396a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b397b000 b39a9000 r-xp /usr/lib/libidn.so.11.5.44
b39b9000 b39cf000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e0000 b39ea000 r-xp /usr/lib/libcares.so.2.1.0
b39fa000 b3a04000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a14000 b3a16000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a26000 b3a27000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a37000 b3a3b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a4c000 b3a74000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a85000 b3aae000 r-xp /usr/lib/libturbojpeg.so
b3ace000 b3ad4000 r-xp /usr/lib/libgif.so.4.1.6
b3ae4000 b3b2a000 r-xp /usr/lib/libcurl.so.4.3.0
b3b3b000 b3b5c000 r-xp /usr/lib/libexif.so.12.3.3
b3b77000 b3b8c000 r-xp /usr/lib/libtts.so
b3b9d000 b3ba5000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bb5000 b3c7b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c9b000 b3d93000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db2000 b3e80000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e97000 b3e99000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ea9000 b3eaf000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ebf000 b3ee2000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef3000 b3ef5000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f05000 b3f07000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f18000 b3f1d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f34000 b3f36000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f46000 b3f4d000 r-xp /usr/lib/libsensord-share.so
b3f5d000 b3f75000 r-xp /usr/lib/libsensor.so.1.1.0
b3f86000 b3f89000 r-xp /usr/lib/libXv.so.1.0.0
b3f99000 b3f9e000 r-xp /usr/lib/libutilX.so.1.1.0
b3fae000 b3fb3000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc3000 b3fca000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fdd000 b3fe1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff2000 b40d0000 r-xp /usr/lib/libCOREGL.so.4.0
b40f0000 b40f3000 r-xp /usr/lib/libuuid.so.1.3.0
b4103000 b411a000 r-xp /usr/lib/libblkid.so.1.1.0
b412b000 b412d000 r-xp /usr/lib/libXau.so.6.0.0
b413d000 b4184000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4196000 b419c000 r-xp /usr/lib/libjson-c.so.2.0.1
b41ad000 b41b1000 r-xp /usr/lib/libogg.so.0.7.1
b41c1000 b41e3000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f3000 b42d7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f3000 b42f6000 r-xp /usr/lib/libEGL.so.1.4
b4307000 b430d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b431d000 b431f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b432f000 b433c000 r-xp /usr/lib/libGLESv2.so.2.0
b434d000 b43af000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43c4000 b43dc000 r-xp /usr/lib/libmount.so.1.1.0
b43ee000 b4402000 r-xp /usr/lib/libxcb.so.1.1.0
b4412000 b4419000 r-xp /lib/libcrypt-2.20-2014.11.so
b4451000 b4453000 r-xp /usr/lib/libiri.so
b4463000 b446e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b447f000 b44b5000 r-xp /usr/lib/libpulse.so.0.16.2
b44c6000 b4509000 r-xp /usr/lib/libsndfile.so.1.0.25
b451e000 b4533000 r-xp /lib/libexpat.so.1.5.2
b4545000 b4603000 r-xp /usr/lib/libcairo.so.2.11200.14
b4617000 b461f000 r-xp /usr/lib/libdrm.so.2.4.0
b462f000 b4632000 r-xp /usr/lib/libdri2.so.0.0.0
b4642000 b4690000 r-xp /usr/lib/libssl.so.1.0.0
b46a5000 b46b1000 r-xp /usr/lib/libeeze.so.1.13.0
b46c2000 b46cb000 r-xp /usr/lib/libethumb.so.1.13.0
b46db000 b46de000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46ee000 b48a5000 r-xp /usr/lib/libcrypto.so.1.0.0
b5690000 b5699000 r-xp /usr/lib/libXi.so.6.1.0
b56a9000 b56ab000 r-xp /usr/lib/libXgesture.so.7.0.0
b56bb000 b56bf000 r-xp /usr/lib/libXtst.so.6.1.0
b56cf000 b56d5000 r-xp /usr/lib/libXrender.so.1.3.0
b56e5000 b56eb000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fb000 b56fd000 r-xp /usr/lib/libXinerama.so.1.0.0
b570e000 b5711000 r-xp /usr/lib/libXfixes.so.3.1.0
b5721000 b572c000 r-xp /usr/lib/libXext.so.6.4.0
b573c000 b573e000 r-xp /usr/lib/libXdamage.so.1.1.0
b574e000 b5750000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5760000 b5842000 r-xp /usr/lib/libX11.so.6.3.0
b5856000 b585d000 r-xp /usr/lib/libXcursor.so.1.0.2
b586d000 b5885000 r-xp /usr/lib/libudev.so.1.6.0
b5887000 b588a000 r-xp /lib/libattr.so.1.1.0
b589a000 b58ba000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58bb000 b58c0000 r-xp /usr/lib/libffi.so.6.0.2
b58d1000 b58e9000 r-xp /lib/libz.so.1.2.8
b58f9000 b58fb000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b590b000 b59e0000 r-xp /usr/lib/libxml2.so.2.9.2
b59f5000 b5a90000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aac000 b5aaf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5abf000 b5ad8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ae9000 b5afa000 r-xp /lib/libresolv-2.20-2014.11.so
b5b0e000 b5b88000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9d000 b5b9f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5baf000 b5bb6000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc6000 b5bd0000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be1000 b5bf9000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0a000 b5c2d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c4e000 b5c62000 r-xp /usr/lib/libector.so.1.13.0
b5c73000 b5c8b000 r-xp /usr/lib/liblua-5.1.so
b5c9c000 b5cf3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d07000 b5d2f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d40000 b5d53000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d64000 b5d9e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5daf000 b5dbd000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dcd000 b5dd5000 r-xp /usr/lib/libtbm.so.1.0.0
b5de5000 b5df2000 r-xp /usr/lib/libeio.so.1.13.0
b5e02000 b5e04000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e14000 b5e19000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e29000 b5e40000 r-xp /usr/lib/libefreet.so.1.13.0
b5e52000 b5e72000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e82000 b5ea2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea4000 b5eaa000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eba000 b5ecb000 r-xp /usr/lib/libemotion.so.1.13.0
b5edc000 b5ee3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef3000 b5f02000 r-xp /usr/lib/libeo.so.1.13.0
b5f13000 b5f25000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f36000 b5f3b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f4b000 b5f64000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f74000 b5f91000 r-xp /usr/lib/libeet.so.1.13.0
b5faa000 b5ff2000 r-xp /usr/lib/libeina.so.1.13.0
b6003000 b6013000 r-xp /usr/lib/libefl.so.1.13.0
b6024000 b6109000 r-xp /usr/lib/libicuuc.so.51.1
b6126000 b6266000 r-xp /usr/lib/libicui18n.so.51.1
b627d000 b62b5000 r-xp /usr/lib/libecore_x.so.1.13.0
b62c7000 b62ca000 r-xp /lib/libcap.so.2.21
b62da000 b6303000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6314000 b631b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b632d000 b6364000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6375000 b6460000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6473000 b64ec000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64fe000 b6503000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6513000 b651d000 r-xp /usr/lib/libvconf.so.0.2.45
b652d000 b652f000 r-xp /usr/lib/libvasum.so.0.3.1
b653f000 b6541000 r-xp /usr/lib/libttrace.so.1.1
b6551000 b6554000 r-xp /usr/lib/libiniparser.so.0
b6564000 b658a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b659a000 b659f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b0000 b65c7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65d8000 b6643000 r-xp /lib/libm-2.20-2014.11.so
b6654000 b665a000 r-xp /lib/librt-2.20-2014.11.so
b666b000 b6678000 r-xp /usr/lib/libunwind.so.8.0.1
b66ae000 b67d2000 r-xp /lib/libc-2.20-2014.11.so
b67e7000 b6800000 r-xp /lib/libgcc_s-4.9.so.1
b6810000 b68f2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6903000 b692d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b693e000 b697a000 r-xp /usr/lib/libsystemd.so.0.4.0
b697c000 b69ff000 r-xp /usr/lib/libedje.so.1.13.0
b6a12000 b6a30000 r-xp /usr/lib/libecore.so.1.13.0
b6a50000 b6bd7000 r-xp /usr/lib/libevas.so.1.13.0
b6c0c000 b6c20000 r-xp /lib/libpthread-2.20-2014.11.so
b6c34000 b6e68000 r-xp /usr/lib/libelementary.so.1.13.0
b6e97000 b6e9b000 r-xp /usr/lib/libsmack.so.1.0.0
b6eab000 b6eb2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec2000 b6ec4000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed4000 b6ed7000 r-xp /usr/lib/libbundle.so.0.1.22
b6ee7000 b6ee9000 r-xp /lib/libdl-2.20-2014.11.so
b6efa000 b6f12000 r-xp /usr/lib/libaul.so.0.1.0
b6f26000 b6f2b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3c000 b6f49000 r-xp /usr/lib/liblptcp.so
b6f5b000 b6f5f000 r-xp /usr/lib/libsys-assert.so
b6f70000 b6f90000 r-xp /lib/ld-2.20-2014.11.so
b6fa1000 b6fa6000 r-xp /usr/bin/launchpad-loader
b7954000 b7d09000 rw-p [heap]
bea22000 bea43000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26392)
Call Stack Count: 4
 0: recv + 0x44 (0xb677b4b4) [/lib/libc.so.6] + 0xcd4b4
 1: recv + 0xfc (0xb6f3fd50) [/usr/lib/liblptcp.so] + 0x3d50
 2: _ZN9AppSocket11receiveDataEv + 0x5a (0xb280e33b) [/opt/usr/apps/org.example.client/bin/client] + 0x1733b
 3: (0x3ff) (null)
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
ck.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-13 18:13:34.393+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-13 18:13:34.393+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-13 18:13:34.393+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-13 18:13:34.393+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-13 18:13:34.393+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-13 18:13:34.403+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
04-13 18:13:34.423+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:13:34.423+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:13:34.423+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:13:34.433+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [com.samsun] 
04-13 18:13:34.433+0900 I/Tizen::System( 1246): (273) > Current App[com.samsun] is already actived.
04-13 18:13:34.433+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:34.433+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:34.463+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:13:34.483+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-13 18:13:34.483+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-13 18:13:34.483+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-13 18:13:34.483+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-13 18:13:34.483+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-13 18:13:34.493+0900 E/LOCKSCREEN(  850): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-13 18:13:34.553+0900 E/PKGMGR_SERVER(26494): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-13 18:13:34.553+0900 E/PKGMGR_SERVER(26494): pkgmgr-server.c: main(2471) > package manager server terminated.
04-13 18:13:34.733+0900 E/weather-agent(26515): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-13 18:13:34.733+0900 I/CAPI_APPFW_APPLICATION(26515): service_app_main.c: service_app_exit(446) > service_app_exit
04-13 18:13:34.733+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-13 18:13:34.733+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-13 18:13:34.733+0900 E/weather-agent(26515): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-13 18:13:34.863+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-13 18:13:34.873+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26515
04-13 18:13:34.883+0900 I/Tizen::App( 1246): (243) > App[com.samsung.weather-m-agent] pid[26515] terminate event is forwarded
04-13 18:13:34.883+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-13 18:13:34.883+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 26515, ]
04-13 18:13:34.883+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-13 18:13:34.883+0900 I/Tizen::App( 1246): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-13 18:13:34.883+0900 I/Tizen::App( 1246): (512) > Not registered pid(26515)
04-13 18:13:34.883+0900 I/Tizen::System( 1246): (246) > Terminated app [com.samsung.weather-m-agent]
04-13 18:13:34.883+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:13:34.883+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26515
04-13 18:13:34.883+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:13:34.883+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 26515.
04-13 18:13:35.434+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.434+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.454+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.454+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.474+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.474+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.494+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.504+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.514+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.514+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.534+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.534+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.554+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.554+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.564+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.564+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.574+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.574+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.594+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.594+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.614+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.614+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.624+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.634+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:35.644+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:13:35.654+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:13:36.064+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:13:36.695+0900 E/PKGMGR  (26597): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-13 18:13:36.765+0900 E/PKGMGR_SERVER(26599): pkgmgr-server.c: main(2414) > package manager server start
04-13 18:13:36.815+0900 E/PKGMGR_SERVER(26599): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-13 18:13:36.825+0900 E/PKGMGR_SERVER(26599): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-13 18:13:36.825+0900 E/PKGMGR  (26597): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[265970002]
04-13 18:13:36.975+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-13 18:13:36.975+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-13 18:13:36.975+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.975+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-13 18:13:36.995+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-13 18:13:36.995+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:36.995+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.165+0900 W/CERT_SVC_VCORE(26602): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-13 18:13:37.255+0900 E/rpm-installer(26602): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-13 18:13:37.255+0900 E/rpm-installer(26602): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-13 18:13:37.316+0900 E/PKGMGR_PARSER(26602): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-13 18:13:37.336+0900 I/PRIVACY-MANAGER-CLIENT(26602): SocketClient.cpp: SocketClient(37) > Client created
04-13 18:13:37.336+0900 I/PRIVACY-MANAGER-CLIENT(26602): SocketClient.cpp: connect(62) > Client connected
04-13 18:13:37.336+0900 I/PRIVACY-MANAGER-SERVER(  938): SocketService.cpp: mainloop(230) > Got incoming connection
04-13 18:13:37.336+0900 I/PRIVACY-MANAGER-CLIENT(26602): SocketClient.cpp: disconnect(72) > Client disconnected
04-13 18:13:37.336+0900 E/PKGMGR_CERT(26602): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-13 18:13:37.346+0900 E/PKGMGR_CERT(26602): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-13 18:13:37.346+0900 E/PKGMGR_CERT(26602): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-13 18:13:37.376+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-13 18:13:37.376+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-13 18:13:37.386+0900 E/rpm-installer(26602): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-13 18:13:37.386+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-13 18:13:37.386+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:37.386+0900 E/ESD     (  919): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-13 18:13:37.396+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-13 18:13:37.396+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-13 18:13:37.406+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-13 18:13:39.097+0900 E/PKGMGR_SERVER(26599): pkgmgr-server.c: sighandler(417) > child NORMAL exit [26602]
04-13 18:13:39.388+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
04-13 18:13:39.558+0900 E/PKGMGR_SERVER(26599): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-13 18:13:39.558+0900 E/PKGMGR_SERVER(26599): pkgmgr-server.c: main(2471) > package manager server terminated.
04-13 18:13:39.738+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-13 18:13:40.198+0900 E/PKGMGR  (26650): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-13 18:13:40.278+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: main(2414) > package manager server start
04-13 18:13:40.328+0900 E/PKGMGR_SERVER(26652): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-13 18:13:40.338+0900 E/PKGMGR_INFO(26652): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-13 18:13:40.338+0900 E/rpm-installer(26652): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-13 18:13:40.348+0900 E/PKGMGR_SERVER(26652): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-13 18:13:40.348+0900 E/PKGMGR  (26650): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[266500002]
04-13 18:13:40.469+0900 E/PKGMGR_INSTALLER(26655): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-13 18:13:40.469+0900 E/rpm-installer(26655): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-13 18:13:40.479+0900 E/rpm-installer(26655): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-13 18:13:40.479+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-13 18:13:40.479+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-13 18:13:40.479+0900 E/rpm-installer(26655): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-13 18:13:40.479+0900 E/rpm-installer(26655): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-13 18:13:40.529+0900 W/CERT_SVC_VCORE(26655): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-13 18:13:40.589+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-13 18:13:40.589+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.589+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-13 18:13:40.599+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-13 18:13:40.599+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-13 18:13:40.859+0900 E/PKGMGR_PARSER(26655): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-13 18:13:40.859+0900 E/PKGMGR_PARSER(26655): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-13 18:13:40.889+0900 I/PRIVACY-MANAGER-CLIENT(26655): SocketClient.cpp: SocketClient(37) > Client created
04-13 18:13:41.099+0900 E/PKGMGR_PARSER(26655): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-13 18:13:41.129+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-13 18:13:41.139+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-13 18:13:41.139+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [60]
04-13 18:13:41.139+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.149+0900 E/rpm-installer(26655): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-13 18:13:41.169+0900 E/rpm-installer(26655): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [100]
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:42.551+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (78) > Installation is Completed. [Package = org.example.client]
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (671) > Enter. package(org.example.client), installationResult(0)
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-13 18:13:43.041+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-13 18:13:43.041+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-13 18:13:43.061+0900 I/Tizen::App( 1246): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-13 18:13:43.081+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-13 18:13:43.081+0900 E/HOME_APPS(  868): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-13 18:13:43.081+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-13 18:13:43.081+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-13 18:13:43.081+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-13 18:13:43.111+0900 E/util-view(  868): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-13 18:13:43.111+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: sighandler(417) > child NORMAL exit [26655]
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-13 18:13:43.111+0900 E/PKGMGR_INFO( 1246): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (683) > Application count(1) in this package
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (703) > Exit.
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (840) > Enter.
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (131) > Enter
04-13 18:13:43.141+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-13 18:13:43.141+0900 I/Tizen::App( 1246): (137) > org.example.client does not have launch condition
04-13 18:13:43.141+0900 I/Tizen::App( 1246): (883) > Exit.
04-13 18:13:44.553+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-13 18:13:44.553+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: main(2471) > package manager server terminated.
04-13 18:13:47.145+0900 W/AUL     (26710): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-13 18:13:47.145+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-13 18:13:47.155+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-13 18:13:47.165+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-13 18:13:47.165+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-13 18:13:47.165+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 26710
04-13 18:13:47.165+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-13 18:13:47.175+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-13 18:13:47.175+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-13 18:13:47.175+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-13 18:13:47.175+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-13 18:13:47.175+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-13 18:13:47.185+0900 I/abc     (26392): abc
04-13 18:13:47.185+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: ui_app_main(789) > app_efl_main
04-13 18:13:47.185+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-13 18:13:47.215+0900 E/TBM     (26392): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-13 18:13:47.275+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 26392, appid: org.example.client
04-13 18:13:47.275+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-13 18:13:47.275+0900 W/AUL     (26710): launch.c: app_request_to_launchpad(425) > request cmd(0) result(26392)
04-13 18:13:47.495+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(514) > [APP 26392] Event: RESET State: CREATED
04-13 18:13:47.495+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-13 18:13:47.505+0900 E/EFL     (26392): edje<26392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:13:47.505+0900 E/EFL     (26392): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:13:47.515+0900 E/EFL     (26392): edje<26392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:13:47.515+0900 E/EFL     (26392): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:13:47.515+0900 E/EFL     (26392): edje<26392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:13:47.515+0900 E/EFL     (26392): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:13:47.526+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:13:47.526+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:13:47.526+0900 W/APP_CORE(26392): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-13 18:13:47.526+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-13 18:13:47.536+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-13 18:13:47.536+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:13:47.546+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:13:47.556+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:13:47.656+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-13 18:13:47.656+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-13 18:13:47.656+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-13 18:13:47.656+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-13 18:13:47.656+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26392) status(3)
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:13:47.656+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(26392)
04-13 18:13:47.656+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 26392, appid: org.example.client, status: fg
04-13 18:13:47.666+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-13 18:13:47.666+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-13 18:13:47.666+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: bg
04-13 18:13:47.676+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(514) > [APP 26392] Event: RESUME State: CREATED
04-13 18:13:47.686+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-13 18:13:47.686+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(625) > [APP 26392] Initial Launching, call the resume_cb
04-13 18:13:47.686+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:13:47.846+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:13:48.016+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26392) status(0)
04-13 18:13:48.326+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-13 18:13:48.326+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 26392.
04-13 18:13:48.326+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1873
04-13 18:13:49.107+0900 I/UXT     (26723): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-13 18:13:52.661+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-13 18:13:56.064+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:13:56.584+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81285031
04-13 18:13:56.584+0900 I/MY_LOG  (26392): Button pressed
04-13 18:13:56.684+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81285130
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26392) : db/ise/keysound error
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-13 18:13:56.765+0900 I/MY_LOG  (26392): Button unpressed
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:14:00.158+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:14
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:14"
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:14"
04-13 18:14:00.158+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146480136 Time: <font_size=31> </font_size> <font_size=31> 오후 6:14</font_size></font>"
04-13 18:14:16.063+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:14:17.515+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81305964
04-13 18:14:17.515+0900 I/MY_LOG  (26392): Button pressed
04-13 18:14:17.595+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81306042
04-13 18:14:17.605+0900 I/MY_LOG  (26392): Button unpressed
04-13 18:14:17.655+0900 D/basicui (26392): successed to load edc file
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.616+0900 E/RESOURCED(  684): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 26392(client)
04-13 18:14:28.616+0900 E/RESOURCED(  684): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 26392(client)
04-13 18:14:28.616+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-13 18:14:28.616+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-13 18:14:28.616+0900 E/RESOURCED(  684): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-13 18:14:28.786+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26392 pgid = 26392
04-13 18:14:28.786+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(26392)
04-13 18:14:28.786+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:14:28.816+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-13 18:14:28.816+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-13 18:14:28.846+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-13 18:14:28.846+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-13 18:14:28.846+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[26392] terminate event is forwarded
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 26392, ]
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (512) > Not registered pid(26392)
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-13 18:14:28.856+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:14:28.856+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26392
04-13 18:14:28.856+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26392
04-13 18:14:28.856+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26392
04-13 18:14:28.856+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1877
04-13 18:14:28.866+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-13 18:14:28.876+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:14:28.876+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-13 18:14:28.876+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:14:28.876+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-13 18:14:28.876+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:14:28.876+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 26392.
04-13 18:14:28.916+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-13 18:14:28.916+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:14:28.926+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:14:28.926+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:14:28.926+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:14:28.936+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:14:28.956+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:28.956+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:28.986+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-13 18:14:28.986+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:14:28.996+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-13 18:14:28.996+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:14:28.996+0900 W/CRASH_MANAGER(26736): worker.c: worker_job(1199) > 0626392636c69149207486
