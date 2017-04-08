S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 1621
Date: 2017-04-06 05:52:22+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 1621, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xb8dccdf8
r2   = 0x00000400, r3   = 0x00000000
r4   = 0xb6f9b114, r5   = 0xb67bd470
r6   = 0xb8f068c0, r7   = 0x00000123
r8   = 0x80074ba7, r9   = 0xb5f54708
r10  = 0xb8f022a0, fp   = 0xbeec5ff4
ip   = 0x00000000, sp   = 0xbeec5fc8
lr   = 0xb412c4c0, pc   = 0xb67bd4b4
cpsr = 0x800f0010

Memory Information
MemTotal:   987012 KB
MemFree:    226500 KB
Buffers:     38196 KB
Cached:     312184 KB
VmPeak:     133912 KB
VmSize:     133908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28228 KB
VmRSS:       28228 KB
VmData:      45848 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 1621 TID = 1621
1621 1624 2063 2064 2072 

Maps Information
af22e000 afa2d000 rw-p [stack:2072]
b0fd1000 b0fe2000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0ff2000 b0ff7000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13f9000 b1401000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1413000 b1c12000 rw-p [stack:2064]
b1c12000 b1c13000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c23000 b1c37000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c4b000 b1c4c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c5c000 b1c5f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c70000 b1c71000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c81000 b1c83000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c93000 b1c95000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ca5000 b1cb5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cc5000 b1cd1000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ce3000 b24e2000 rw-p [stack:2063]
b2813000 b281a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b282d000 b2833000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2843000 b285f000 r-xp /opt/usr/apps/org.example.client/bin/client
b29b8000 b2a9b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ad2000 b2afa000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b0c000 b330b000 rw-p [stack:1624]
b330b000 b330d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b331d000 b3327000 r-xp /lib/libnss_files-2.20-2014.11.so
b3338000 b3341000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3352000 b3363000 r-xp /lib/libnsl-2.20-2014.11.so
b3376000 b337c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b338d000 b338e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33b6000 b33bd000 r-xp /usr/lib/libminizip.so.1.0.0
b33cd000 b33d2000 r-xp /usr/lib/libstorage.so.0.1
b33e2000 b3441000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3457000 b346b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b347b000 b34bf000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34cf000 b34d7000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34e7000 b3517000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b352a000 b35e3000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35f7000 b364a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b365b000 b3676000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3686000 b3747000 r-xp /usr/lib/libprotobuf.so.9.0.1
b375a000 b376a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b377a000 b3787000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3798000 b379f000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37af000 b37f0000 r-xp /usr/lib/libmdm.so.1.2.12
b3800000 b3808000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3817000 b3827000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3848000 b38a8000 r-xp /usr/lib/libasound.so.2.0.0
b38ba000 b38bd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38cd000 b38d0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38e0000 b38e5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38f5000 b38f6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3906000 b3911000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3925000 b392c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b393c000 b3942000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3952000 b3957000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3967000 b3982000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3992000 b3999000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39a9000 b39ac000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39bd000 b39eb000 r-xp /usr/lib/libidn.so.11.5.44
b39fb000 b3a11000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a22000 b3a2c000 r-xp /usr/lib/libcares.so.2.1.0
b3a3c000 b3a46000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a56000 b3a58000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a68000 b3a69000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a79000 b3a7d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a8e000 b3ab6000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ac7000 b3af0000 r-xp /usr/lib/libturbojpeg.so
b3b10000 b3b16000 r-xp /usr/lib/libgif.so.4.1.6
b3b26000 b3b6c000 r-xp /usr/lib/libcurl.so.4.3.0
b3b7d000 b3b9e000 r-xp /usr/lib/libexif.so.12.3.3
b3bb9000 b3bce000 r-xp /usr/lib/libtts.so
b3bdf000 b3be7000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bf7000 b3cbd000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cdd000 b3dd5000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df4000 b3ec2000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ed9000 b3edb000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eeb000 b3ef1000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f01000 b3f24000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f35000 b3f37000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f47000 b3f49000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5a000 b3f5f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f76000 b3f78000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f88000 b3f8f000 r-xp /usr/lib/libsensord-share.so
b3f9f000 b3fb7000 r-xp /usr/lib/libsensor.so.1.1.0
b3fc8000 b3fcb000 r-xp /usr/lib/libXv.so.1.0.0
b3fdb000 b3fe0000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff0000 b3ff5000 r-xp /usr/lib/libappcore-common.so.1.1
b4005000 b400c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b401f000 b4023000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4034000 b4112000 r-xp /usr/lib/libCOREGL.so.4.0
b4132000 b4135000 r-xp /usr/lib/libuuid.so.1.3.0
b4145000 b415c000 r-xp /usr/lib/libblkid.so.1.1.0
b416d000 b416f000 r-xp /usr/lib/libXau.so.6.0.0
b417f000 b41c6000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41d8000 b41de000 r-xp /usr/lib/libjson-c.so.2.0.1
b41ef000 b41f3000 r-xp /usr/lib/libogg.so.0.7.1
b4203000 b4225000 r-xp /usr/lib/libvorbis.so.0.4.3
b4235000 b4319000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4335000 b4338000 r-xp /usr/lib/libEGL.so.1.4
b4349000 b434f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b435f000 b4361000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4371000 b437e000 r-xp /usr/lib/libGLESv2.so.2.0
b438f000 b43f1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4406000 b441e000 r-xp /usr/lib/libmount.so.1.1.0
b4430000 b4444000 r-xp /usr/lib/libxcb.so.1.1.0
b4454000 b445b000 r-xp /lib/libcrypt-2.20-2014.11.so
b4493000 b4495000 r-xp /usr/lib/libiri.so
b44a5000 b44b0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c1000 b44f7000 r-xp /usr/lib/libpulse.so.0.16.2
b4508000 b454b000 r-xp /usr/lib/libsndfile.so.1.0.25
b4560000 b4575000 r-xp /lib/libexpat.so.1.5.2
b4587000 b4645000 r-xp /usr/lib/libcairo.so.2.11200.14
b4659000 b4661000 r-xp /usr/lib/libdrm.so.2.4.0
b4671000 b4674000 r-xp /usr/lib/libdri2.so.0.0.0
b4684000 b46d2000 r-xp /usr/lib/libssl.so.1.0.0
b46e7000 b46f3000 r-xp /usr/lib/libeeze.so.1.13.0
b4704000 b470d000 r-xp /usr/lib/libethumb.so.1.13.0
b471d000 b4720000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4730000 b48e7000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d2000 b56db000 r-xp /usr/lib/libXi.so.6.1.0
b56eb000 b56ed000 r-xp /usr/lib/libXgesture.so.7.0.0
b56fd000 b5701000 r-xp /usr/lib/libXtst.so.6.1.0
b5711000 b5717000 r-xp /usr/lib/libXrender.so.1.3.0
b5727000 b572d000 r-xp /usr/lib/libXrandr.so.2.2.0
b573d000 b573f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5750000 b5753000 r-xp /usr/lib/libXfixes.so.3.1.0
b5763000 b576e000 r-xp /usr/lib/libXext.so.6.4.0
b577e000 b5780000 r-xp /usr/lib/libXdamage.so.1.1.0
b5790000 b5792000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a2000 b5884000 r-xp /usr/lib/libX11.so.6.3.0
b5898000 b589f000 r-xp /usr/lib/libXcursor.so.1.0.2
b58af000 b58c7000 r-xp /usr/lib/libudev.so.1.6.0
b58c9000 b58cc000 r-xp /lib/libattr.so.1.1.0
b58dc000 b58fc000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58fd000 b5902000 r-xp /usr/lib/libffi.so.6.0.2
b5913000 b592b000 r-xp /lib/libz.so.1.2.8
b593b000 b593d000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b594d000 b5a22000 r-xp /usr/lib/libxml2.so.2.9.2
b5a37000 b5ad2000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aee000 b5af1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b01000 b5b1a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b2b000 b5b3c000 r-xp /lib/libresolv-2.20-2014.11.so
b5b50000 b5bca000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bdf000 b5be1000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf1000 b5bf8000 r-xp /usr/lib/libembryo.so.1.13.0
b5c08000 b5c12000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c23000 b5c3b000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4c000 b5c6f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c90000 b5ca4000 r-xp /usr/lib/libector.so.1.13.0
b5cb5000 b5ccd000 r-xp /usr/lib/liblua-5.1.so
b5cde000 b5d35000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d49000 b5d71000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d82000 b5d95000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da6000 b5de0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df1000 b5dff000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e0f000 b5e17000 r-xp /usr/lib/libtbm.so.1.0.0
b5e27000 b5e34000 r-xp /usr/lib/libeio.so.1.13.0
b5e44000 b5e46000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e56000 b5e5b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6b000 b5e82000 r-xp /usr/lib/libefreet.so.1.13.0
b5e94000 b5eb4000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec4000 b5ee4000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee6000 b5eec000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efc000 b5f0d000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1e000 b5f25000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f35000 b5f44000 r-xp /usr/lib/libeo.so.1.13.0
b5f55000 b5f67000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f78000 b5f7d000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8d000 b5fa6000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb6000 b5fd3000 r-xp /usr/lib/libeet.so.1.13.0
b5fec000 b6034000 r-xp /usr/lib/libeina.so.1.13.0
b6045000 b6055000 r-xp /usr/lib/libefl.so.1.13.0
b6066000 b614b000 r-xp /usr/lib/libicuuc.so.51.1
b6168000 b62a8000 r-xp /usr/lib/libicui18n.so.51.1
b62bf000 b62f7000 r-xp /usr/lib/libecore_x.so.1.13.0
b6309000 b630c000 r-xp /lib/libcap.so.2.21
b631c000 b6345000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6356000 b635d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b636f000 b63a6000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b7000 b64a2000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b5000 b652e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6540000 b6545000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6555000 b655f000 r-xp /usr/lib/libvconf.so.0.2.45
b656f000 b6571000 r-xp /usr/lib/libvasum.so.0.3.1
b6581000 b6583000 r-xp /usr/lib/libttrace.so.1.1
b6593000 b6596000 r-xp /usr/lib/libiniparser.so.0
b65a6000 b65cc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65dc000 b65e1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f2000 b6609000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661a000 b6685000 r-xp /lib/libm-2.20-2014.11.so
b6696000 b669c000 r-xp /lib/librt-2.20-2014.11.so
b66ad000 b66ba000 r-xp /usr/lib/libunwind.so.8.0.1
b66f0000 b6814000 r-xp /lib/libc-2.20-2014.11.so
b6829000 b6842000 r-xp /lib/libgcc_s-4.9.so.1
b6852000 b6934000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6945000 b696f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6980000 b69bc000 r-xp /usr/lib/libsystemd.so.0.4.0
b69be000 b6a41000 r-xp /usr/lib/libedje.so.1.13.0
b6a54000 b6a72000 r-xp /usr/lib/libecore.so.1.13.0
b6a92000 b6c19000 r-xp /usr/lib/libevas.so.1.13.0
b6c4e000 b6c62000 r-xp /lib/libpthread-2.20-2014.11.so
b6c76000 b6eaa000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed9000 b6edd000 r-xp /usr/lib/libsmack.so.1.0.0
b6eed000 b6ef4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f04000 b6f06000 r-xp /usr/lib/libdlog.so.0.0.0
b6f16000 b6f19000 r-xp /usr/lib/libbundle.so.0.1.22
b6f29000 b6f2b000 r-xp /lib/libdl-2.20-2014.11.so
b6f3c000 b6f54000 r-xp /usr/lib/libaul.so.0.1.0
b6f68000 b6f6d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7e000 b6f8b000 r-xp /usr/lib/liblptcp.so
b6f9d000 b6fa1000 r-xp /usr/lib/libsys-assert.so
b6fb2000 b6fd2000 r-xp /lib/ld-2.20-2014.11.so
b6fe3000 b6fe8000 r-xp /usr/bin/launchpad-loader
b8b7f000 b8f5f000 rw-p [heap]
beea6000 beec7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1621)
Call Stack Count: 4
 0: recv + 0x44 (0xb67bd4b4) [/lib/libc.so.6] + 0xcd4b4
 1: recv + 0xfc (0xb6f81d50) [/usr/lib/liblptcp.so] + 0x3d50
 2: _ZN9AppSocket11receiveDataEv + 0x5a (0xb28534a7) [/opt/usr/apps/org.example.client/bin/client] + 0x104a7
 3: (0x400) (null)
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
cb(244) > "time format : 오전 5:49"
04-06 05:49:00.446+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:49:00.446+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147059394 Time: <font_size=31> </font_size> <font_size=31> 오전 5:49</font_size></font>"
04-06 05:49:14.980+0900 I/abc     ( 1777): abc
04-06 05:49:14.990+0900 I/CAPI_APPFW_APPLICATION( 1777): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:49:16.142+0900 I/CAPI_APPFW_APPLICATION( 1777): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:49:16.972+0900 I/SERVICE_MANAGER_LIB( 1001): service-manager.c: service_manager_unregister_listener2(564) > [34m[1001]service_manager_unregister_object[0m
04-06 05:49:17.243+0900 W/AUL_AMD (  610): amd_main.c: __platform_ready_handler(491) > [Info]__platform_ready_handler
04-06 05:49:18.244+0900 E/TBM     ( 1777): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:49:19.315+0900 D/basicui ( 1777): successed to load edc file
04-06 05:49:19.355+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:49:19.355+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:49:19.375+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:49:19.375+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:49:19.385+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:49:19.385+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:49:20.065+0900 I/MY_LOG  ( 1777): change
04-06 05:49:20.125+0900 I/APP_CORE( 1777): appcore-efl.c: __do_app(514) > [APP 1777] Event: RESET State: CREATED
04-06 05:49:20.125+0900 I/CAPI_APPFW_APPLICATION( 1777): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:49:20.156+0900 W/APP_CORE( 1777): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-06 05:49:20.156+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:49:20.386+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 05:49:20.386+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:49:20.386+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 05:49:20.386+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 05:49:20.386+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 05:49:20.386+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 05:49:20.396+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1777) status(3)
04-06 05:49:20.396+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:49:20.396+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:49:20.396+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(1777)
04-06 05:49:20.396+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1777, appid: org.example.client, status: fg
04-06 05:49:20.396+0900 I/APP_CORE( 1777): appcore-efl.c: __do_app(514) > [APP 1777] Event: RESUME State: CREATED
04-06 05:49:20.406+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:49:20.406+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:49:20.406+0900 W/AUL     ( 1406): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1406, appid: com.samsung.weather-m-widget, status: bg
04-06 05:49:20.426+0900 I/APP_CORE( 1777): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:49:20.426+0900 I/APP_CORE( 1777): appcore-efl.c: __do_app(625) > [APP 1777] Initial Launching, call the resume_cb
04-06 05:49:20.426+0900 I/CAPI_APPFW_APPLICATION( 1777): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:49:20.766+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1777) status(0)
04-06 05:49:22.007+0900 I/MY_LOG  ( 1777): Button pressed
04-06 05:49:22.067+0900 E/VCONF   ( 1777): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:49:22.067+0900 E/VCONF   ( 1777): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:49:22.067+0900 E/VCONF   ( 1777): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:49:22.077+0900 E/VCONF   ( 1777): vconf.c: vconf_get_bool(2729) > vconf_get_bool(1777) : db/ise/keysound error
04-06 05:49:22.077+0900 E/VCONF   ( 1777): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:49:22.077+0900 E/VCONF   ( 1777): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:49:22.137+0900 I/MY_LOG  ( 1777): Button unpressed
04-06 05:49:25.391+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: MEM_FLUSH State: PAUSED
04-06 05:49:45.260+0900 E/DOWNLOAD_PROVIDER(  914): download-provider-db.c: dp_db_get_ids(437) > check connection handle
04-06 05:49:45.260+0900 I/AUL     (  914): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/download-provider, ret : 0
04-06 05:49:45.270+0900 I/AUL     (  914): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/download-provider, ret : 0
04-06 05:49:45.270+0900 I/DOWNLOAD_PROVIDER(  914): download-provider-client-manager.c: dp_client_manager(732) > client-manager's working is done
04-06 05:49:45.290+0900 W/WIFI_DIRECT_MANAGER( 1089): wifi-direct-client.c: wfd_client_process_request(912) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 32 bytes read from socket[13]
04-06 05:49:45.290+0900 E/WIFI_DIRECT(  914): wifi-direct-client-proxy.c: __wfd_client_check_socket(554) > Error! POLLHUP from socket[8]
04-06 05:49:45.290+0900 E/WIFI_DIRECT(  914): wifi-direct-client-proxy.c: __wfd_client_read_socket(614) > Socket error
04-06 05:49:45.290+0900 E/WIFI_DIRECT(  914): wifi-direct-client-proxy.c: __wfd_client_send_request(663) > Failed to read socket [-29753342]
04-06 05:49:45.290+0900 I/CAPI_NETWORK_CONNECTION(  914): connection.c: __connection_set_type_changed_callback(181) > Successfully de-registered(0)
04-06 05:49:45.290+0900 I/CAPI_NETWORK_CONNECTION(  914): connection.c: __connection_set_ip_changed_callback(266) > Successfully de-registered(0)
04-06 05:49:45.290+0900 I/CAPI_NETWORK_CONNECTION(  914): connection.c: connection_destroy(427) > Destroy handle: 0xb7194900
04-06 05:49:45.310+0900 I/DOWNLOAD_PROVIDER(  914): download-provider-main.c: main(70) > download-provider's working is done
04-06 05:49:49.774+0900 E/EFL     ( 1248): eldbus<1248> lib/eldbus/eldbus_proxy.c:785 _props_get_all() Error getting all properties of org.a11y.Bus /org/a11y/bus, error message: org.freedesktop.DBus.Error.TimedOut Activation of org.a11y.Bus timed out
04-06 05:50:00.445+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:50:00.455+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:50
04-06 05:50:00.455+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 5:50"
04-06 05:50:00.455+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:50"
04-06 05:50:00.455+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:50:00.455+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147026049 Time: <font_size=31> </font_size> <font_size=31> 오전 5:50</font_size></font>"
04-06 05:50:15.319+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.319+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.319+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.319+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:50:15.329+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:00.443+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:51:00.453+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:51
04-06 05:51:00.453+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 5:51"
04-06 05:51:00.453+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:51"
04-06 05:51:00.453+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:51:00.453+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146996295 Time: <font_size=31> </font_size> <font_size=31> 오전 5:51</font_size></font>"
04-06 05:51:02.966+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:51:02.986+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 05:51:02.986+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:51:02.986+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:51:02.986+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 05:51:02.986+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 05:51:03.026+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:51:03.046+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 05:51:03.046+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:51:03.046+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 05:51:03.066+0900 E/weather-widget( 1406): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:51:03.076+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:51:03.076+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:51:03.086+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 05:51:03.126+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:51:03.126+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:51:03.126+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:51:03.126+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:51:03.126+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:51:03.136+0900 E/weather-widget( 1406): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:51:03.146+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:51:03.156+0900 E/weather-common( 1406): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:51:03.196+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_create(409) > New handle created[0xb89e88a8]
04-06 05:51:03.196+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:51:03.196+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_destroy(427) > Destroy handle: 0xb89e88a8
04-06 05:51:03.196+0900 E/weather-common( 1406): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:51:03.196+0900 E/weather-widget( 1406): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:51:03.206+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:51:03.206+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:51:03.206+0900 W/AUL     ( 1406): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1406, appid: com.samsung.weather-m-widget, status: fg
04-06 05:51:03.977+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.977+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.977+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.977+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:03.987+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:53.195+0900 E/PKGMGR_SERVER( 1854): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:51:53.245+0900 E/PKGMGR  ( 1852): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 05:51:53.275+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:51:53.275+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 1777
04-06 05:51:53.285+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 05:51:53.295+0900 E/PKGMGR_SERVER( 1854): pkgmgr-server.c: sighandler(417) > child NORMAL exit [1857]
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:55.177+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:51:55.897+0900 E/PKGMGR_SERVER( 1854): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:51:55.897+0900 E/PKGMGR_SERVER( 1854): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:51:57.299+0900 E/PKGMGR  ( 1941): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 05:51:57.369+0900 E/PKGMGR_SERVER( 1943): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:51:57.419+0900 E/PKGMGR_SERVER( 1943): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 05:51:57.429+0900 E/PKGMGR_SERVER( 1943): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 05:51:57.429+0900 E/PKGMGR  ( 1941): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[19410002]
04-06 05:51:57.589+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 05:51:57.589+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 05:51:57.589+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 05:51:57.599+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:51:57.599+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [30]
04-06 05:51:57.599+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:51:57.769+0900 W/CERT_SVC_VCORE( 1946): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:51:57.859+0900 E/rpm-installer( 1946): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 05:51:57.859+0900 E/rpm-installer( 1946): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 05:51:57.909+0900 E/PKGMGR_PARSER( 1946): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 05:51:57.929+0900 I/PRIVACY-MANAGER-CLIENT( 1946): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:51:57.929+0900 I/PRIVACY-MANAGER-CLIENT( 1946): SocketClient.cpp: connect(62) > Client connected
04-06 05:51:57.929+0900 I/PRIVACY-MANAGER-SERVER(  922): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 05:51:57.929+0900 I/PRIVACY-MANAGER-CLIENT( 1946): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 05:51:57.939+0900 E/PKGMGR_CERT( 1946): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 05:51:57.939+0900 E/PKGMGR_CERT( 1946): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 05:51:57.949+0900 E/PKGMGR_CERT( 1946): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 05:51:57.979+0900 E/rpm-installer( 1946): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 05:51:57.989+0900 E/ESD     (  901): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 05:51:57.989+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 05:51:57.989+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-06 05:51:57.989+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 05:51:58.000+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 05:51:58.000+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 05:51:59.661+0900 E/PKGMGR_SERVER( 1943): pkgmgr-server.c: sighandler(417) > child NORMAL exit [1946]
04-06 05:51:59.891+0900 E/PKGMGR_SERVER( 1943): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:51:59.891+0900 E/PKGMGR_SERVER( 1943): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:52:00.452+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:52:00.512+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:52
04-06 05:52:00.512+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 5:52"
04-06 05:52:00.512+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:52"
04-06 05:52:00.512+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:52:00.512+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146922421 Time: <font_size=31> </font_size> <font_size=31> 오전 5:52</font_size></font>"
04-06 05:52:00.842+0900 E/PKGMGR  ( 1995): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 05:52:00.912+0900 E/PKGMGR_SERVER( 1997): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:52:00.972+0900 E/PKGMGR_SERVER( 1997): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 05:52:00.982+0900 E/PKGMGR_INFO( 1997): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 05:52:00.982+0900 E/rpm-installer( 1997): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 05:52:00.992+0900 E/PKGMGR_SERVER( 1997): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 05:52:00.992+0900 E/PKGMGR  ( 1995): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[19950002]
04-06 05:52:01.113+0900 E/PKGMGR_INSTALLER( 2000): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 05:52:01.113+0900 E/rpm-installer( 2000): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 05:52:01.133+0900 E/rpm-installer( 2000): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 05:52:01.133+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 05:52:01.133+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:52:01.133+0900 E/rpm-installer( 2000): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 05:52:01.133+0900 E/rpm-installer( 2000): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:52:01.183+0900 W/CERT_SVC_VCORE( 2000): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:52:01.243+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 05:52:01.243+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-06 05:52:01.253+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:52:01.253+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [30]
04-06 05:52:01.253+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:52:01.483+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 05:52:01.483+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 05:52:01.483+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 05:52:01.483+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:52:01.483+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 05:52:01.483+0900 E/rpm-installer( 2000): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 05:52:01.493+0900 E/PKGMGR_PARSER( 2000): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 05:52:01.493+0900 E/PKGMGR_PARSER( 2000): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 05:52:01.533+0900 I/PRIVACY-MANAGER-CLIENT( 2000): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:52:01.743+0900 E/PKGMGR_PARSER( 2000): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 05:52:01.763+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 05:52:01.763+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 05:52:01.763+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 05:52:01.763+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 05:52:01.763+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 05:52:01.763+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 05:52:01.773+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 05:52:01.773+0900 E/PKGMGR_CERT( 2000): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 05:52:01.783+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 05:52:01.783+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [60]
04-06 05:52:01.783+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-06 05:52:01.793+0900 E/rpm-installer( 2000): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:52:01.823+0900 E/rpm-installer( 2000): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 05:52:01.823+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 05:52:01.823+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [100]
04-06 05:52:01.823+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-06 05:52:02.894+0900 E/PKGMGR_SERVER( 1997): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:52:03.735+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 05:52:03.735+0900 I/Tizen::App( 1248): (78) > Installation is Completed. [Package = org.example.client]
04-06 05:52:03.735+0900 I/Tizen::App( 1248): (671) > Enter. package(org.example.client), installationResult(0)
04-06 05:52:03.745+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 05:52:03.745+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 05:52:03.745+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 05:52:03.785+0900 E/PKGMGR_SERVER( 1997): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2000]
04-06 05:52:03.795+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 05:52:03.805+0900 I/Tizen::App( 1248): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 05:52:03.825+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 05:52:03.825+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 05:52:03.825+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 05:52:03.825+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 05:52:03.825+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 05:52:03.825+0900 I/Tizen::App( 1248): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 05:52:03.835+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 05:52:03.835+0900 E/HOME_APPS(  869): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 05:52:03.835+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 05:52:03.835+0900 W/HOME_APPS(  869): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 05:52:03.845+0900 I/Tizen::App( 1248): (416) > appName = [client]
04-06 05:52:03.845+0900 I/Tizen::App( 1248): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:52:03.845+0900 E/PKGMGR_INFO( 1248): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 05:52:03.845+0900 I/Tizen::App( 1248): (683) > Application count(1) in this package
04-06 05:52:03.845+0900 I/Tizen::App( 1248): (840) > Enter.
04-06 05:52:03.845+0900 I/Tizen::App( 1248): (703) > Exit.
04-06 05:52:03.845+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-06 05:52:03.855+0900 I/Tizen::App( 1248): (416) > appName = [client]
04-06 05:52:03.855+0900 I/Tizen::App( 1248): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:52:03.855+0900 I/Tizen::App( 1248): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 05:52:03.855+0900 I/Tizen::App( 1248): (131) > Enter
04-06 05:52:03.855+0900 E/util-view(  869): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 05:52:03.855+0900 I/Tizen::App( 1248): (137) > org.example.client does not have launch condition
04-06 05:52:03.855+0900 I/Tizen::App( 1248): (883) > Exit.
04-06 05:52:03.875+0900 W/HOME_APPS(  869): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 05:52:04.896+0900 E/PKGMGR_SERVER( 1997): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:52:04.896+0900 E/PKGMGR_SERVER( 1997): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:52:07.939+0900 W/AUL     ( 2056): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 05:52:07.939+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:52:07.949+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 05:52:07.959+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 05:52:07.959+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:52:07.959+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 2056
04-06 05:52:07.959+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:52:07.969+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 05:52:07.969+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:52:07.969+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:52:07.969+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:52:07.969+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:52:07.989+0900 I/abc     ( 1621): abc
04-06 05:52:07.989+0900 I/CAPI_APPFW_APPLICATION( 1621): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:52:07.989+0900 I/CAPI_APPFW_APPLICATION( 1621): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:52:08.009+0900 E/TBM     ( 1621): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:52:08.069+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 1621, appid: org.example.client
04-06 05:52:08.069+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:52:08.089+0900 W/AUL     ( 2056): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1621)
04-06 05:52:08.270+0900 D/basicui ( 1621): successed to load edc file
04-06 05:52:08.310+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:08.310+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:08.320+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:52:08.320+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:08.330+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:08.340+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:52:08.360+0900 I/MY_LOG  ( 1621): change
04-06 05:52:08.410+0900 I/APP_CORE( 1621): appcore-efl.c: __do_app(514) > [APP 1621] Event: RESET State: CREATED
04-06 05:52:08.410+0900 I/CAPI_APPFW_APPLICATION( 1621): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:52:08.420+0900 E/EFL     ( 1621): edje<1621> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:08.420+0900 E/EFL     ( 1621): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:08.430+0900 E/EFL     ( 1621): edje<1621> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:08.430+0900 E/EFL     ( 1621): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:08.430+0900 E/EFL     ( 1621): edje<1621> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:08.430+0900 E/EFL     ( 1621): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:08.430+0900 W/APP_CORE( 1621): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6800002
04-06 05:52:08.440+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:52:08.540+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 05:52:08.540+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:52:08.540+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 05:52:08.550+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 05:52:08.550+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 05:52:08.550+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 05:52:08.550+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1621) status(3)
04-06 05:52:08.550+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:52:08.550+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:52:08.550+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(1621)
04-06 05:52:08.550+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1621, appid: org.example.client, status: fg
04-06 05:52:08.560+0900 I/APP_CORE( 1621): appcore-efl.c: __do_app(514) > [APP 1621] Event: RESUME State: CREATED
04-06 05:52:08.560+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:52:08.560+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:52:08.560+0900 W/AUL     ( 1406): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1406, appid: com.samsung.weather-m-widget, status: bg
04-06 05:52:08.580+0900 I/APP_CORE( 1621): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:52:08.580+0900 I/APP_CORE( 1621): appcore-efl.c: __do_app(625) > [APP 1621] Initial Launching, call the resume_cb
04-06 05:52:08.580+0900 I/CAPI_APPFW_APPLICATION( 1621): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:52:08.920+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1621) status(0)
04-06 05:52:09.140+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-06 05:52:09.140+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 1621.
04-06 05:52:09.140+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.251
04-06 05:52:09.891+0900 I/UXT     ( 2069): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:52:11.042+0900 E/EFL     ( 1621): ecore_x<1621> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=288145
04-06 05:52:11.042+0900 I/MY_LOG  ( 1621): Button pressed
04-06 05:52:11.152+0900 E/EFL     ( 1621): ecore_x<1621> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=288267
04-06 05:52:11.162+0900 E/VCONF   ( 1621): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:52:11.162+0900 E/VCONF   ( 1621): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:52:11.162+0900 E/VCONF   ( 1621): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:52:11.162+0900 E/VCONF   ( 1621): vconf.c: vconf_get_bool(2729) > vconf_get_bool(1621) : db/ise/keysound error
04-06 05:52:11.162+0900 E/VCONF   ( 1621): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:52:11.162+0900 E/VCONF   ( 1621): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:52:11.212+0900 I/MY_LOG  ( 1621): Button unpressed
04-06 05:52:13.555+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: MEM_FLUSH State: PAUSED
04-06 05:52:22.163+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 1621(client)
04-06 05:52:22.163+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 1621(client)
04-06 05:52:22.163+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-06 05:52:22.163+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-06 05:52:22.163+0900 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-06 05:52:22.323+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:22.333+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1621 pgid = 1621
04-06 05:52:22.333+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(1621)
04-06 05:52:22.333+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 05:52:22.333+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:52:22.333+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:52:22.333+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 05:52:22.333+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 05:52:22.393+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 05:52:22.403+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 05:52:22.403+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:52:22.403+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 05:52:22.403+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:22.423+0900 E/weather-widget( 1406): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:52:22.433+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:52:22.433+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:22.443+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:52:22.443+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:52:22.443+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 05:52:22.443+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 1621
04-06 05:52:22.443+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1621
04-06 05:52:22.443+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 1621
04-06 05:52:22.443+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:52:22.443+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:52:22.443+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:52:22.443+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:52:22.453+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:52:22.453+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.255
04-06 05:52:22.453+0900 E/weather-widget( 1406): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:52:22.473+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:22.473+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[1621] terminate event is forwarded
04-06 05:52:22.473+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 05:52:22.473+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 1621, ]
04-06 05:52:22.473+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 05:52:22.473+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-06 05:52:22.473+0900 I/Tizen::App( 1248): (512) > Not registered pid(1621)
04-06 05:52:22.473+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-06 05:52:22.473+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:22.483+0900 E/weather-common( 1406): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:52:22.513+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:22.513+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 1621.
04-06 05:52:22.523+0900 W/CRASH_MANAGER( 2079): worker.c: worker_job(1199) > 0601621636c69149142554
